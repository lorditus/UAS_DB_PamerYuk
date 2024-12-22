using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatListUC_P : UserControl
    {
        public readonly ChatService service;
        public readonly MainForm main;
        

        public ChatListUC_P(ChatService service, MainForm main)
        {
            InitializeComponent();
            this.service = service;
            this.main = main;

            //Panel buttonPanel = new Panel
            //{
            //    BorderStyle = BorderStyle.None,
            //    Margin = new Padding(0)
            //};
        }

        private void ChatListUC_P_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel flowChatList = new FlowLayoutPanel();
           
            this.Controls.Add(flowChatList);
            int i;

            flowChatList.Size = new System.Drawing.Size(485, (this.Size.Height - lblHeaderChat.Height - textBox1.Height));
            flowChatList.Location = new System.Drawing.Point(0, (textBox1.Height + lblHeaderChat.Height));
            for (i = 0; i <= 5; i++)
            {
                
                SingleContact sc = new SingleContact(service, this);
                sc.setTestSample(i);
                sc.BackColor = ColorUtil.palette["soft-white"];

                flowChatList.Controls.Add(sc);
            }
            this.textBox1.Visible = true;
            this.lblHeaderChat.Visible = true;

        }

        public void reloadLayout()
        {
            this.Controls.RemoveAt(2);
            FlowLayoutPanel flowChatList = new FlowLayoutPanel();

            this.Controls.Add(flowChatList);
            int i;

            flowChatList.Size = new System.Drawing.Size(485, (this.Size.Height - lblHeaderChat.Height - textBox1.Height));
            flowChatList.Location = new System.Drawing.Point(0, (textBox1.Height + lblHeaderChat.Height));
            for (i = 0; i <= 5; i++)
            {

                SingleContact sc = new SingleContact(service, this);
                sc.setTestSample(i);
                sc.BackColor = ColorUtil.palette["soft-white"];

                flowChatList.Controls.Add(sc);
            }
            this.textBox1.Visible = true;
            this.lblHeaderChat.Visible = true;
        }
        string comand, filter;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comand = "";
            filter = textBox1.Text;
            if (textBox1.Text != null)
            {
                comand = "select * from user where username like '%"+filter+"%';";
            }
            Connection.JalankanSelect(comand);
            ChatListUC_P_Load(sender, e);
        }
    }
}
