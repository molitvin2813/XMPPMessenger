namespace Messenger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StopServer = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.PasswordServerBox = new System.Windows.Forms.TextBox();
            this.PasswordServerLabel = new System.Windows.Forms.Label();
            this.PortServerLabel = new System.Windows.Forms.Label();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.PortServerBox = new System.Windows.Forms.TextBox();
            this.TabServer = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServerLog = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TabClient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ChatHistory = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabServer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabClient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopServer
            // 
            this.StopServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StopServer.Enabled = false;
            this.StopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopServer.Location = new System.Drawing.Point(7, 154);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(192, 48);
            this.StopServer.TabIndex = 8;
            this.StopServer.Text = "Остановить сервер";
            this.StopServer.UseVisualStyleBackColor = false;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // StartServer
            // 
            this.StartServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer.Location = new System.Drawing.Point(7, 89);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(192, 48);
            this.StartServer.TabIndex = 7;
            this.StartServer.Text = "Запустить сервер";
            this.StartServer.UseVisualStyleBackColor = false;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // PasswordServerBox
            // 
            this.PasswordServerBox.Location = new System.Drawing.Point(74, 38);
            this.PasswordServerBox.Name = "PasswordServerBox";
            this.PasswordServerBox.PasswordChar = '*';
            this.PasswordServerBox.Size = new System.Drawing.Size(125, 29);
            this.PasswordServerBox.TabIndex = 6;
            this.PasswordServerBox.Text = "0000";
            // 
            // PasswordServerLabel
            // 
            this.PasswordServerLabel.AutoSize = true;
            this.PasswordServerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordServerLabel.Location = new System.Drawing.Point(3, 41);
            this.PasswordServerLabel.Name = "PasswordServerLabel";
            this.PasswordServerLabel.Size = new System.Drawing.Size(68, 22);
            this.PasswordServerLabel.TabIndex = 4;
            this.PasswordServerLabel.Text = "Пароль:";
            // 
            // PortServerLabel
            // 
            this.PortServerLabel.AutoSize = true;
            this.PortServerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PortServerLabel.Location = new System.Drawing.Point(3, 6);
            this.PortServerLabel.Name = "PortServerLabel";
            this.PortServerLabel.Size = new System.Drawing.Size(52, 22);
            this.PortServerLabel.TabIndex = 2;
            this.PortServerLabel.Text = "Порт:";
            // 
            // ServerPanel
            // 
            this.ServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerPanel.Location = new System.Drawing.Point(3, 3);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(886, 29);
            this.ServerPanel.TabIndex = 2;
            // 
            // PortServerBox
            // 
            this.PortServerBox.Location = new System.Drawing.Point(74, 3);
            this.PortServerBox.Name = "PortServerBox";
            this.PortServerBox.Size = new System.Drawing.Size(125, 29);
            this.PortServerBox.TabIndex = 5;
            this.PortServerBox.Text = "50505";
            // 
            // TabServer
            // 
            this.TabServer.Controls.Add(this.panel2);
            this.TabServer.Controls.Add(this.ServerLog);
            this.TabServer.Controls.Add(this.ServerPanel);
            this.TabServer.Location = new System.Drawing.Point(4, 31);
            this.TabServer.Name = "TabServer";
            this.TabServer.Padding = new System.Windows.Forms.Padding(3);
            this.TabServer.Size = new System.Drawing.Size(892, 422);
            this.TabServer.TabIndex = 1;
            this.TabServer.Text = "Сервер";
            this.TabServer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.StopServer);
            this.panel2.Controls.Add(this.StartServer);
            this.panel2.Controls.Add(this.PortServerBox);
            this.panel2.Controls.Add(this.PortServerLabel);
            this.panel2.Controls.Add(this.PasswordServerBox);
            this.panel2.Controls.Add(this.PasswordServerLabel);
            this.panel2.Location = new System.Drawing.Point(685, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 211);
            this.panel2.TabIndex = 6;
            // 
            // ServerLog
            // 
            this.ServerLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ServerLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerLog.Location = new System.Drawing.Point(3, 32);
            this.ServerLog.Multiline = true;
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.ReadOnly = true;
            this.ServerLog.Size = new System.Drawing.Size(886, 387);
            this.ServerLog.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(82, 111);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(124, 29);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Text = "0000";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(8, 114);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 22);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // Disconnect
            // 
            this.Disconnect.Enabled = false;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disconnect.Location = new System.Drawing.Point(5, 236);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(201, 69);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Отключиться от сервера";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Connect.Location = new System.Drawing.Point(6, 161);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(201, 69);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Подключиться к серверу";
            this.Connect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortBox.Location = new System.Drawing.Point(82, 41);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(124, 29);
            this.PortBox.TabIndex = 3;
            this.PortBox.Text = "50505";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLabel.Location = new System.Drawing.Point(9, 44);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(52, 22);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Порт:";
            // 
            // IPBox
            // 
            this.IPBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPBox.Location = new System.Drawing.Point(82, 6);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(125, 29);
            this.IPBox.TabIndex = 2;
            this.IPBox.Text = "127.0.0.1";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPLabel.Location = new System.Drawing.Point(9, 9);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(29, 22);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP:";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(82, 76);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(124, 29);
            this.NameBox.TabIndex = 9;
            this.NameBox.Text = "user";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(8, 79);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 22);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Ник:";
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.panel1);
            this.TabClient.Controls.Add(this.ChatHistory);
            this.TabClient.Controls.Add(this.MessagePanel);
            this.TabClient.Controls.Add(this.label1);
            this.TabClient.Location = new System.Drawing.Point(4, 31);
            this.TabClient.Name = "TabClient";
            this.TabClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabClient.Size = new System.Drawing.Size(892, 422);
            this.TabClient.TabIndex = 0;
            this.TabClient.Text = "Клиент";
            this.TabClient.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.IPLabel);
            this.panel1.Controls.Add(this.IPBox);
            this.panel1.Controls.Add(this.PortBox);
            this.panel1.Controls.Add(this.PortLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Controls.Add(this.Disconnect);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Location = new System.Drawing.Point(677, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 389);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(15, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Подключение не активно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(22, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Подключение активно";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Закрыть чат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatHistory
            // 
            this.ChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatHistory.Location = new System.Drawing.Point(3, 3);
            this.ChatHistory.Multiline = true;
            this.ChatHistory.Name = "ChatHistory";
            this.ChatHistory.ReadOnly = true;
            this.ChatHistory.Size = new System.Drawing.Size(886, 391);
            this.ChatHistory.TabIndex = 4;
            // 
            // MessagePanel
            // 
            this.MessagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagePanel.Controls.Add(this.button2);
            this.MessagePanel.Controls.Add(this.MessageTextBox);
            this.MessagePanel.Controls.Add(this.SendMessage);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessagePanel.Enabled = false;
            this.MessagePanel.Location = new System.Drawing.Point(3, 394);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(886, 25);
            this.MessagePanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(855, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 15);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(673, 28);
            this.MessageTextBox.TabIndex = 2;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            this.MessageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageTextBox_KeyPress);
            // 
            // SendMessage
            // 
            this.SendMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessage.Location = new System.Drawing.Point(673, 0);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(211, 23);
            this.SendMessage.TabIndex = 1;
            this.SendMessage.Text = ">>>      ";
            this.SendMessage.UseVisualStyleBackColor = false;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::Messenger.Properties.Resources.ima1ge;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 389);
            this.label1.TabIndex = 6;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TabClient);
            this.Tabs.Controls.Add(this.TabServer);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabs.ItemSize = new System.Drawing.Size(150, 27);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.MaximumSize = new System.Drawing.Size(999999, 9999999);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(900, 457);
            this.Tabs.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 457);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabServer.ResumeLayout(false);
            this.TabServer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabClient.ResumeLayout(false);
            this.TabClient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.TextBox PasswordServerBox;
        private System.Windows.Forms.Label PasswordServerLabel;
        private System.Windows.Forms.Label PortServerLabel;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.TextBox PortServerBox;
        private System.Windows.Forms.TabPage TabServer;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TabPage TabClient;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.TextBox ChatHistory;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ServerLog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

