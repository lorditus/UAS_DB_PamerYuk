using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatListUC : UserControl
    {
        private readonly ChatService service;

        public ChatListUC(ChatService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void ChatListUC_Load(object sender, EventArgs e)
        {

        }
    }
}
