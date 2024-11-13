using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class SearchUC : UserControl
    {
        private readonly FriendshipService service;

        public SearchUC(FriendshipService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {

        }
    }
}
