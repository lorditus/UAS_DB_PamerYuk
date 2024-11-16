using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class FriendListUC : UserControl
    {
        private readonly FriendshipService service;
        private readonly MainForm mainForm;

        public FriendListUC(FriendshipService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void FriendListUC_Load(object sender, EventArgs e)
        {

        }
    }
}
