namespace SerialTester
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortListDropDown = new System.Windows.Forms.ComboBox();
            this.BaudComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.sendGroupBox = new System.Windows.Forms.GroupBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.receiveGroupBox = new System.Windows.Forms.GroupBox();
            this.readButton = new System.Windows.Forms.Button();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.socketTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendGroupBox.SuspendLayout();
            this.receiveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortListDropDown
            // 
            this.PortListDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortListDropDown.FormattingEnabled = true;
            this.PortListDropDown.Location = new System.Drawing.Point(451, 38);
            this.PortListDropDown.Name = "PortListDropDown";
            this.PortListDropDown.Size = new System.Drawing.Size(100, 24);
            this.PortListDropDown.TabIndex = 0;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudComboBox.FormattingEnabled = true;
            this.BaudComboBox.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudComboBox.Location = new System.Drawing.Point(451, 93);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.Size = new System.Drawing.Size(100, 24);
            this.BaudComboBox.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(579, 147);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 42);
            this.progressBar.TabIndex = 2;
            // 
            // sendGroupBox
            // 
            this.sendGroupBox.Controls.Add(this.sendTextBox);
            this.sendGroupBox.Location = new System.Drawing.Point(30, 38);
            this.sendGroupBox.Name = "sendGroupBox";
            this.sendGroupBox.Size = new System.Drawing.Size(180, 201);
            this.sendGroupBox.TabIndex = 3;
            this.sendGroupBox.TabStop = false;
            this.sendGroupBox.Text = "Send";
            // 
            // sendTextBox
            // 
            this.sendTextBox.Enabled = false;
            this.sendTextBox.Location = new System.Drawing.Point(0, 36);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(180, 126);
            this.sendTextBox.TabIndex = 0;
            this.sendTextBox.TextChanged += new System.EventHandler(this.sendTextBox_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(129, 206);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton);
            // 
            // receiveGroupBox
            // 
            this.receiveGroupBox.Controls.Add(this.readButton);
            this.receiveGroupBox.Controls.Add(this.ReceiveTextBox);
            this.receiveGroupBox.Location = new System.Drawing.Point(245, 38);
            this.receiveGroupBox.Name = "receiveGroupBox";
            this.receiveGroupBox.Size = new System.Drawing.Size(180, 201);
            this.receiveGroupBox.TabIndex = 4;
            this.receiveGroupBox.TabStop = false;
            this.receiveGroupBox.Text = "Receive";
            // 
            // readButton
            // 
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(99, 168);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.Read);
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Enabled = false;
            this.ReceiveTextBox.Location = new System.Drawing.Point(0, 36);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.ReadOnly = true;
            this.ReceiveTextBox.Size = new System.Drawing.Size(180, 126);
            this.ReceiveTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(451, 138);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Open Port";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButtonClicked);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(451, 187);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 32);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Close Port";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.Close);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // socketTextBox
            // 
            this.socketTextBox.Location = new System.Drawing.Point(579, 91);
            this.socketTextBox.Multiline = true;
            this.socketTextBox.Name = "socketTextBox";
            this.socketTextBox.Size = new System.Drawing.Size(100, 26);
            this.socketTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Socket";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 247);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.socketTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.receiveGroupBox);
            this.Controls.Add(this.sendGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BaudComboBox);
            this.Controls.Add(this.PortListDropDown);
            this.Name = "MainForm";
            this.Text = "Serial Port Tester";
            this.sendGroupBox.ResumeLayout(false);
            this.sendGroupBox.PerformLayout();
            this.receiveGroupBox.ResumeLayout(false);
            this.receiveGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox PortListDropDown;
        private System.Windows.Forms.ComboBox BaudComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox sendGroupBox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox receiveGroupBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox socketTextBox;
        private System.Windows.Forms.Label label4;
    }
}

