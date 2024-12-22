using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class SingleContact : UserControl
    {
        public readonly ChatService service;
        public readonly ChatListUC_P chat;
        public readonly MainForm main;


        public SingleContact(ChatService service, ChatListUC_P chatlist)
        {
            InitializeComponent();
            this.service = service;
            this.chat = chatlist;
        }

        //untuk keperluan testing
        public void setTestSample(int index)
        {
            if (index%2==0)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser2;
                lblNamaKontak.Text = "kevin"+index;
            }
            else 
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser3;
                lblNamaKontak.Text = "daniel"+index;
            }
        }

        private void SingleContact_Click(object sender, EventArgs e)
        {
            ChatRoomUC load = new ChatRoomUC(service, chat);
            chat.Controls.Add(load);
            chat.Controls[2].Visible = false;
            chat.reloadLayout();
            chat.lblHeaderChat.Visible = false;
            chat.textBox1.Visible = false;
        }
    }
}
