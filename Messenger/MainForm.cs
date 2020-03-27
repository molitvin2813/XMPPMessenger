using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace Messenger
{
    public partial class MainForm : Form
    {
        List<Client> clients = new List<Client>();

        bool serverIsRunning = false;
        bool clientConnected = false;

        private int sendTimeout = 5;
        private int readTimeout = 5;
        private int inactiveTimeout = 300;
        private int sleepTime = 5;
        private int maximumClients = 2;

        class Client
        {
            public DateTime LastActivity;
            public Socket Socket;
            public string Name;

            public Client(DateTime connectionTime, Socket socket, string name)
            {
                LastActivity = connectionTime;
                Socket = socket;
                Name = name;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            StartServer.Enabled = false;
            serverPassword = PasswordServerBox.Text;
            serverPort = 50505;
            int.TryParse(PortServerBox.Text, out serverPort);
            serverThread = new Thread(ServerListening);
            serverThread.Start();
            StopServer.Enabled = true;
         
        }

        Thread serverThread = null;
        string serverPassword = "";
        int serverPort;

        Socket client = null;
        Thread clientThread = null;

        private void ServerListening()
        {
            try
            {
                Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(new IPEndPoint(IPAddress.Any, serverPort));
                listener.Listen(0);
                serverIsRunning = true;
                Thread serverProcessingThread = new Thread(ServerProcessing);
                serverProcessingThread.Start();
                while (serverIsRunning)
                {
                    if (listener.Poll(0, SelectMode.SelectRead))
                    {
                        Socket socket = listener.Accept();
                        bool authorizedConnection = false;
                        JObject response = new JObject();
                        response.Add("result", "error");
                        string request = "";
                        //чтение запроса
                        if ((request = ReceiveRequest(socket)).Length > 0)
                        {
                            JObject data = JObject.Parse(request);
                            string action = data.GetValue("action").ToString();
                            //обработка запроса
                            if (action == "authorization")
                            {
                                //чтение и проверка пароля
                                string name = data.GetValue("name").ToString();
                                string password = data.GetValue("password").ToString();
                                if (password.Equals(serverPassword))
                                {
                                    //добавление клиента в очередь
                                    Client client = null;
                                    if ((client = clients.Find(item => item.Name == name)) == null)
                                    {
                                        if (clients.Count < maximumClients)
                                        {
                                            response["result"] = "success";
                                            string text = string.Format("[{0}]: {1} connected", DateTime.Now.ToString("H:m:ss"), name);
                                            Invoke((MethodInvoker)(() =>
                                            {
                                                ServerLog.AppendText(text + Environment.NewLine);
                                            }));
                                            //уведомление других клиентов
                                            JObject notification = new JObject();
                                            notification.Add("action", "message");
                                            notification.Add("message", text);
                                            for (int j = 0; j < clients.Count; ++j)
                                            {
                                                SendRequest(clients[j].Socket, notification);
                                            }
                                            //добавление клиента в очередь
                                            clients.Add(new Client(DateTime.Now, socket, name));
                                            authorizedConnection = true;
                                        }
                                        else
                                        {
                                            response.Add("message", "Server is full!");
                                        }
                                    }
                                    else
                                    {
                                        response.Add("message", "User with this name already exists!");
                                    }
                                }
                                else
                                {
                                    response.Add("message", "Invalid password!");
                                }
                            }
                            else
                            {
                                response.Add("message", "You are not authorized!");
                            }
                        }
                        //формирование и отправка ответа
                        SendRequest(socket, response);
                        //если поключенный клиент не авторизовался
                        if (!authorizedConnection)
                        {
                            socket.Close();
                        }
                    }
                    else
                    {
                        Thread.Sleep(sleepTime);
                    }
                }
                listener.Close();
                while (serverProcessingThread.IsAlive)
                {
                    Thread.Sleep(sleepTime);
                }
            }
            catch (ThreadAbortException)
            {

            }
            catch (Exception exception)
            {
                Invoke((MethodInvoker)(() =>
                {
                    StartServer.Enabled = true;
                    StopServer.Enabled = false;
                    ServerLog.Clear();
                }));
                MessageBox.Show(exception.Message);
            }
        }

        private string ReceiveRequest(Socket socket)
        {
            string result = "";
            byte[] buffer = ReceiveData(socket, 8);
            if (buffer.Length == 8)
            {
                long length = BitConverter.ToInt64(buffer, 0);
                buffer = ReceiveData(socket, length);
                if (buffer.Length == length)
                {
                    result = Encoding.Unicode.GetString(buffer);
                }
            }
            return result;
        }

        private byte[] ReceiveData(Socket socket, long length)
        {
            byte[] buffer = new byte[0];
            DateTime time = DateTime.Now;
            BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());
            while (binaryWriter.BaseStream.Length < length && (DateTime.Now - time).TotalSeconds < readTimeout)
            {
                while (socket.Available == 0 && (DateTime.Now - time).TotalSeconds < readTimeout)
                {
                    Thread.Sleep(sleepTime);
                }
                if (socket.Available > 0)
                {
                    buffer = new byte[Math.Min(socket.Available, length - binaryWriter.BaseStream.Length)];
                    socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    binaryWriter.Write(buffer);
                }
            }
            buffer = binaryWriter.BaseStream.Length < length ? new byte[0] : ((MemoryStream)binaryWriter.BaseStream).ToArray();
            return buffer;
        }

        private void ServerProcessing()
        {
            Queue<string> disconnected = new Queue<string>();
            while (serverIsRunning)
            {
                for (int i = 0; i < clients.Count; ++i)
                {
                    try
                    {
                        string request = "";
                        //чтение запроса
                        if ((request = ReceiveRequest(clients[i].Socket)).Length > 0)
                        {
                            JObject data = JObject.Parse(request);
                            string action = data.GetValue("action").ToString();
                            if (action == "send_message")
                            {
                                string message = data.GetValue("message").ToString();
                                string text = string.Format("[{0}]: {1}: {2}", DateTime.Now.ToString("H:m:ss"), clients[i].Name, message);
                                Invoke((MethodInvoker)(() =>
                                {
                                    ServerLog.AppendText(text + Environment.NewLine);
                                }));
                                JObject response = new JObject();
                                response.Add("action", "message");
                                response.Add("message", text);
                                for (int j = 0; j < clients.Count; ++j)
                                {
                                    SendRequest(clients[j].Socket, response);
                                }
                            }
                            else if (action == "disconnect")
                            {
                                disconnected.Enqueue(clients[i].Name);
                            }
                        }
                        //если клиент долго не отправлял запросов
                        else if ((DateTime.Now - clients[i].LastActivity).TotalSeconds > inactiveTimeout)
                        {
                            disconnected.Enqueue(clients[i].Name);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                try
                {
                    //удаление из очереди отключенных клиентов
                    if (disconnected.Count > 0)
                    {
                        while (disconnected.Count > 0)
                        {
                            string name = disconnected.Dequeue();
                            Client client = clients.Find(item => item.Name == name);
                            //уведомление клиента
                            JObject notification = new JObject();
                            notification.Add("action", "disconnect");
                            SendRequest(client.Socket, notification);
                            //удаление клиента
                            clients.RemoveAll(item => item.Name == name);
                            string text = string.Format("[{0}]: {1} disconnected", DateTime.Now.ToString("H:m:ss"), name);
                            Invoke((MethodInvoker)(() =>
                            {
                                ServerLog.AppendText(text + Environment.NewLine);
                            }));
                            //уведомление других клиентов
                            notification = new JObject();
                            notification.Add("action", "message");
                            notification.Add("message", text);
                            for (int j = 0; j < clients.Count; ++j)
                            {
                                SendRequest(clients[j].Socket, notification);
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            //отключение клиентов
            for (int i = 0; i < clients.Count; ++i)
            {
                try
                {
                    //уведомление клиента
                    JObject notification = new JObject();
                    notification.Add("action", "disconnect");
                    SendRequest(clients[i].Socket, notification);
                    clients[i].Socket.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            clients.Clear();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = false;
            clientThread = new Thread(ClientProcesssing);
            clientThread.Start();
            label2.Visible = true;
            label3.Visible = false;
        }

        private void ClientProcesssing()
        {
            try
            {
                //подключение к серверу
                client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                int port = 50505;
                int.TryParse(PortBox.Text, out port);
                client.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), port));
                client.SendTimeout = sendTimeout;
                //отправка запроса авторизации
                JObject request = new JObject();
                request.Add("action", "authorization");
                request.Add("name", NameBox.Text);
                request.Add("password", PasswordBox.Text);
                SendRequest(client, request);
                string resultString = "";
                //чтение ответа
                if ((resultString = ReceiveRequest(client)).Length > 0)
                {
                    JObject result = JObject.Parse(resultString);
                    if (result.GetValue("result").ToString() == "success")
                    {
                        clientConnected = true;
                        Invoke((MethodInvoker)(() =>
                        {
                            MessagePanel.Enabled = true;
                            Disconnect.Enabled = true;
                            MessageTextBox.Focus();
                        }));
                        bool disconnectFromServer = false;
                        //работа клиента
                        while (clientConnected)
                        {
                            //чтение данных
                            if (client.Available >= 8 && (resultString = ReceiveRequest(client)).Length > 0)
                            {
                                result = JObject.Parse(resultString);
                                string action = result.GetValue("action").ToString();
                                if (action == "message")
                                {
                                    string text = result.GetValue("message").ToString();
                                    Invoke((MethodInvoker)(() =>
                                    {
                                        label1.Text = label1.Text + (text + Environment.NewLine);
                                        ChatHistory.AppendText(text + Environment.NewLine);
                                    }));
                                }
                                else if (action == "disconnect")
                                {
                                    disconnectFromServer = true;
                                    clientConnected = false;
                                }
                            }
                        }
                        //запрос отключения
                        if (!disconnectFromServer)
                        {
                            request = new JObject();
                            request.Add("action", "disconnect");
                            SendRequest(client, request);
                        }
                        DisconnectUpdateUI();
                        //отключение от сервера
                        client.Close();
                    }
                    else
                    {
                        client.Close();
                        DisconnectUpdateUI();
                        MessageBox.Show(result.GetValue("message").ToString());
                    }
                }
                else
                {
                    client.Close();
                    DisconnectUpdateUI();
                    MessageBox.Show("Unable to connect!");
                }
            }
            catch (ThreadAbortException)
            {

            }
            catch (Exception exception)
            {
                DisconnectUpdateUI();
                MessageBox.Show(exception.Message);
            }
        }

        private void DisconnectUpdateUI()
        {
            Invoke((MethodInvoker)(() =>
            {
                Connect.Enabled = true;
                MessagePanel.Enabled = false;
                Disconnect.Enabled = false;
                ChatHistory.Clear();
                Connect.Focus();
                MessageTextBox.Clear();
            }));
        }

        private void SendRequest(Socket socket, JObject request)
        {
            byte[] data = Encoding.Unicode.GetBytes(request.ToString());
            BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());
            binaryWriter.Write((long)data.Length);
            binaryWriter.Write(data);
            byte[] buffer = ((MemoryStream)binaryWriter.BaseStream).ToArray();
            socket.Send(buffer);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientConnected = false;
            serverIsRunning = false;
            if (serverThread != null && serverThread.IsAlive)
            {
                serverThread.Abort();
            }
            if (clientThread != null && clientThread.IsAlive)
            {
                clientThread.Abort();
            }
        }

        //jnjk
        //    lmkl

        private void StopServer_Click(object sender, EventArgs e)
        {
           
            serverIsRunning = false;
            StartServer.Enabled = true;
            StopServer.Enabled = false;
            StartServer.Focus();
            ServerLog.Clear();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            clientConnected = false;
            label3.Visible = true;
            label2.Visible = false;
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            SendText();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (!clientConnected)
            {
                Connect.Enabled = NameBox.TextLength > 3;
            }
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            //button3.Enabled = MessageTextBox.TextLength > 0;
        }

        private void MessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendText();
            }
        }

        private void SendText()
        {
            JObject request = new JObject();
            request.Add("action", "send_message");
            request.Add("message", MessageTextBox.Text);
            SendRequest(client, request);
            MessageTextBox.Clear();
            MessageTextBox.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(1, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = button2.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                button2.BackColor = Color.FromArgb(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.ForeColor = button2.BackColor;
        }
    }
}
