using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatRoomUC : UserControl
    {
        private readonly ChatService service;
        private readonly ChatListUC_P mainForm;
        
        public ChatRoomUC(ChatService service, ChatListUC_P mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void ChatRoomUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
            this.mainForm.textBox1.Visible = false;
            this.mainForm.lblHeaderChat.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.HomeButton_clicked;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainForm.Controls.Remove(this);
            this.mainForm.textBox1.Visible = true;
            this.mainForm.lblHeaderChat.Visible = true;
            this.mainForm.Controls[2].Visible = true;
        }
    }
}
