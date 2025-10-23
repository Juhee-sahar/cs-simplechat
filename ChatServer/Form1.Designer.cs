namespace ChatServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnectServer = new Button();
            btnDisconnectServer = new Button();
            label1 = new Label();
            labelClintList = new Label();
            label3 = new Label();
            labelChatLog = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox2 = new TextBox();
            btnSendMsg = new Button();
            SuspendLayout();
            // 
            // btnConnectServer
            // 
            btnConnectServer.Location = new Point(9, 9);
            btnConnectServer.Margin = new Padding(2);
            btnConnectServer.Name = "btnConnectServer";
            btnConnectServer.Size = new Size(288, 30);
            btnConnectServer.TabIndex = 0;
            btnConnectServer.Text = "연결 대기";
            btnConnectServer.UseVisualStyleBackColor = true;
            btnConnectServer.Click += BtnAcceptIncoming_Click;
            // 
            // btnDisconnectServer
            // 
            btnDisconnectServer.Location = new Point(311, 9);
            btnDisconnectServer.Margin = new Padding(2);
            btnDisconnectServer.Name = "btnDisconnectServer";
            btnDisconnectServer.Size = new Size(288, 30);
            btnDisconnectServer.TabIndex = 1;
            btnDisconnectServer.Text = "서버 종료";
            btnDisconnectServer.UseVisualStyleBackColor = true;
            btnDisconnectServer.Click += BtnDisconnectServer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "클라이언트 리스트";
            // 
            // labelClintList
            // 
            labelClintList.BackColor = SystemColors.ButtonHighlight;
            labelClintList.BorderStyle = BorderStyle.FixedSingle;
            labelClintList.Location = new Point(9, 80);
            labelClintList.Margin = new Padding(2, 0, 2, 0);
            labelClintList.Name = "labelClintList";
            labelClintList.Size = new Size(200, 330);
            labelClintList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "채팅 로그";
            // 
            // labelChatLog
            // 
            labelChatLog.BackColor = SystemColors.ButtonHighlight;
            labelChatLog.BorderStyle = BorderStyle.FixedSingle;
            labelChatLog.Location = new Point(225, 80);
            labelChatLog.Margin = new Padding(2, 0, 2, 0);
            labelChatLog.Name = "labelChatLog";
            labelChatLog.Size = new Size(375, 330);
            labelChatLog.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 420);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 6;
            label5.Text = "클라이언트에 메세지 전송";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 437);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(590, 71);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(9, 512);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "모든 사용자";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 514);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 9;
            label6.Text = "IP : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 512);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSendMsg
            // 
            btnSendMsg.Location = new Point(482, 512);
            btnSendMsg.Margin = new Padding(2);
            btnSendMsg.Name = "btnSendMsg";
            btnSendMsg.Size = new Size(117, 23);
            btnSendMsg.TabIndex = 11;
            btnSendMsg.Text = "전송";
            btnSendMsg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 565);
            Controls.Add(btnSendMsg);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(labelChatLog);
            Controls.Add(label3);
            Controls.Add(labelClintList);
            Controls.Add(label1);
            Controls.Add(btnDisconnectServer);
            Controls.Add(btnConnectServer);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectServer;
        private Button btnDisconnectServer;
        private Label label1;
        private Label labelClintList;
        private Label label3;
        private Label labelChatLog;
        private Label label5;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox textBox2;
        private Button btnSendMsg;
    }
}
