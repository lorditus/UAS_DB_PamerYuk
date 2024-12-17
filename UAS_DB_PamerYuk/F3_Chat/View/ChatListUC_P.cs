using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatListUC_P : UserControl
    {
        private readonly ChatService service;
        private readonly MainForm mainForm;

        public ChatListUC_P(ChatService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void ChatListUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
