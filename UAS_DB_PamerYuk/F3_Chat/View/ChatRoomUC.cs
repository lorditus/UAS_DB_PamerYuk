using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatRoomUC : UserControl
    {
        private readonly ChatService service;

        public ChatRoomUC(ChatService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void ChatRoomUC_Load(object sender, EventArgs e)
        {

        }
    }
}
