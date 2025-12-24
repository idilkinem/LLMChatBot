using System;
using System.Windows.Forms;
using LLMChatBot.Bot;

namespace LLMChatBot
{
    public partial class Form1 : Form
    {
        private readonly BotEngine _bot = new BotEngine();

        public Form1()
        {
            InitializeComponent();

            // Gönder butonuna tıklama olayı
            btnSend.Click += BtnSend_Click;

            // Enter ile gönder (Shift+Enter alt satır)
            txtMessage.KeyDown += TxtMessage_KeyDown;
        }

        private void TxtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string userText = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(userText))
                return;

            AddLine("Sen", userText);

            txtMessage.Clear();
            txtMessage.Focus();

            // Offline bot cevabı
            string reply = _bot.GetReply(userText);
            AddLine("Bot", reply);
        }

        private void AddLine(string who, string text)
        {
            lstChat.Items.Add($"{who}: {text}");
            lstChat.TopIndex = lstChat.Items.Count - 1;
        }
    }
}
