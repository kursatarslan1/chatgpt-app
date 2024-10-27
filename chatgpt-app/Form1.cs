using chatgpt_app.service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatgpt_app
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        bool gptOrGemini = true;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            pnlChat.AutoScroll = true;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaxNormal_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlMiddle_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UpdateStatus(bool waitOrReady)
        {
            if (waitOrReady) // true ise ready false ise wait
            {
                lblStatus.Text = "Hazır";
                lblStatus.ForeColor = Color.LimeGreen;
                btnSendMessage.Enabled = true;
                txtMessage.Enabled = true;
            } else
            {
                lblStatus.Text = "Mesaj Gönderildi, yanıt bekleniyor...";
                lblStatus.ForeColor = Color.Yellow;
                txtMessage.Clear();
                btnSendMessage.Enabled = false;
                txtMessage.Enabled = false;
            }
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            
            string userMessage = txtMessage.Text;
            UpdateStatus(false);

            if(string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Mesaj boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddMessageToChat(userMessage, true);
            string botReply = await _context.SendMessage(userMessage, gptOrGemini);

            if (botReply != null)
            {
                AddMessageToChat(botReply, false);
            }
            else
            {
                MessageBox.Show("Bot'tan yanıt alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            UpdateStatus(true);
        }

        private void AddMessageToChat(string message, bool isUserMessage)
        {
            Guna2TextBox messageTextBox = new Guna2TextBox();
            messageTextBox.Multiline = true;
            messageTextBox.ReadOnly = true;
            messageTextBox.Width = pnlChat.Width - 20;

            messageTextBox.Font = new Font("Arial", 12, FontStyle.Regular); // Fontu büyütün
            string sender = isUserMessage ? "Sen: " : gptOrGemini ? "ChatGPT: " : "Gemini: ";

            messageTextBox.Text = sender + message;
            messageTextBox.BackColor = isUserMessage ? Color.LightBlue : Color.LightGray;

            int lineCount = messageTextBox.Text.Split('\n').Length;
            messageTextBox.Height = Math.Max(50, 15 * lineCount); 

            pnlChat.Controls.Add(messageTextBox);
            pnlChat.ScrollControlIntoView(messageTextBox);
        }

        private void btnUseChatGpt_Click(object sender, EventArgs e)
        {
            gptOrGemini = true;
            lblAI2.Text = "ChatGPT";
            lblAI2.ForeColor = Color.DarkCyan;
            pictureBox1.Image = Properties.Resources.chatgpt_85e25;
        }

        private void btnUseGemini_Click(object sender, EventArgs e)
        {
            gptOrGemini = false;
            lblAI2.Text = "Gemini";
            lblAI2.ForeColor = Color.BlueViolet;
            pictureBox1.Image = Properties.Resources.gemini_turkce_1068x580;
        }
    }
}
