using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class FriendListUC : UserControl
    {
        private readonly FriendshipService service;

        public FriendListUC(FriendshipService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FriendListUC_Load(object sender, EventArgs e)
        {

        }
    }
}
