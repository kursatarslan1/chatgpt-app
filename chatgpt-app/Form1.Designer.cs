namespace chatgpt_app
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMaxNormal = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnSendMessage = new Guna.UI2.WinForms.Guna2Button();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUseChatGpt = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUseGemini = new Guna.UI2.WinForms.Guna2Button();
            this.lblAI = new System.Windows.Forms.Label();
            this.lblAI2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblAI2);
            this.panel1.Controls.Add(this.lblAI);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaxNormal);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(983, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(39, 43);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxNormal
            // 
            this.btnMaxNormal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxNormal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxNormal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaxNormal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaxNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxNormal.FillColor = System.Drawing.Color.Green;
            this.btnMaxNormal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaxNormal.ForeColor = System.Drawing.Color.White;
            this.btnMaxNormal.Location = new System.Drawing.Point(1022, 0);
            this.btnMaxNormal.Name = "btnMaxNormal";
            this.btnMaxNormal.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMaxNormal.Size = new System.Drawing.Size(39, 43);
            this.btnMaxNormal.TabIndex = 2;
            this.btnMaxNormal.Text = "O";
            this.btnMaxNormal.Click += new System.EventHandler(this.btnMaxNormal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1061, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(39, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLeft.Controls.Add(this.btnUseGemini);
            this.pnlLeft.Controls.Add(this.panel5);
            this.pnlLeft.Controls.Add(this.btnUseChatGpt);
            this.pnlLeft.Controls.Add(this.panel4);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 43);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLeft.Size = new System.Drawing.Size(196, 651);
            this.pnlLeft.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 100);
            this.panel4.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(186, 100);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Hazır";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 39);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 100);
            this.panel2.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlChat);
            this.pnlMiddle.Controls.Add(this.pnlMessage);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(196, 43);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(904, 651);
            this.pnlMiddle.TabIndex = 2;
            // 
            // pnlChat
            // 
            this.pnlChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(904, 569);
            this.pnlChat.TabIndex = 1;
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMessage.Controls.Add(this.btnSendMessage);
            this.pnlMessage.Controls.Add(this.txtMessage);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMessage.Location = new System.Drawing.Point(0, 569);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMessage.Size = new System.Drawing.Size(904, 82);
            this.pnlMessage.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMessage.FillColor = System.Drawing.Color.Black;
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(735, 20);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(149, 42);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Gönder";
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(20, 20);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtMessage.PlaceholderText = "Mesajınızı Buraya Giriniz...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(864, 42);
            this.txtMessage.TabIndex = 0;
            // 
            // btnUseChatGpt
            // 
            this.btnUseChatGpt.BorderRadius = 15;
            this.btnUseChatGpt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUseChatGpt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUseChatGpt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUseChatGpt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUseChatGpt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUseChatGpt.FillColor = System.Drawing.Color.DarkCyan;
            this.btnUseChatGpt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUseChatGpt.ForeColor = System.Drawing.Color.White;
            this.btnUseChatGpt.Location = new System.Drawing.Point(5, 144);
            this.btnUseChatGpt.Name = "btnUseChatGpt";
            this.btnUseChatGpt.Size = new System.Drawing.Size(186, 45);
            this.btnUseChatGpt.TabIndex = 3;
            this.btnUseChatGpt.Text = "ChatGPT kullan";
            this.btnUseChatGpt.Click += new System.EventHandler(this.btnUseChatGpt_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 22);
            this.panel5.TabIndex = 4;
            // 
            // btnUseGemini
            // 
            this.btnUseGemini.BorderRadius = 15;
            this.btnUseGemini.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUseGemini.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUseGemini.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUseGemini.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUseGemini.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUseGemini.FillColor = System.Drawing.Color.BlueViolet;
            this.btnUseGemini.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUseGemini.ForeColor = System.Drawing.Color.White;
            this.btnUseGemini.Location = new System.Drawing.Point(5, 211);
            this.btnUseGemini.Name = "btnUseGemini";
            this.btnUseGemini.Size = new System.Drawing.Size(186, 45);
            this.btnUseGemini.TabIndex = 5;
            this.btnUseGemini.Text = "Gemini\'yi kullan";
            this.btnUseGemini.Click += new System.EventHandler(this.btnUseGemini_Click);
            // 
            // lblAI
            // 
            this.lblAI.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAI.Location = new System.Drawing.Point(0, 0);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(131, 43);
            this.lblAI.TabIndex = 4;
            this.lblAI.Text = "Kullanılan Yapay Zeka: ";
            this.lblAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAI2
            // 
            this.lblAI2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAI2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAI2.Location = new System.Drawing.Point(131, 0);
            this.lblAI2.Name = "lblAI2";
            this.lblAI2.Size = new System.Drawing.Size(116, 43);
            this.lblAI2.TabIndex = 5;
            this.lblAI2.Text = "ChatGPT";
            this.lblAI2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::chatgpt_app.Properties.Resources.chatgpt_85e25;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 694);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ChatBot";
            this.panel1.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnMaxNormal;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlMessage;
        private Guna.UI2.WinForms.Guna2Button btnSendMessage;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnUseGemini;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnUseChatGpt;
        private System.Windows.Forms.Label lblAI2;
        private System.Windows.Forms.Label lblAI;
    }
}

