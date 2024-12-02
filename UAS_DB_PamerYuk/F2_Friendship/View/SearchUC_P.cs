using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class SearchUC_P : UserControl
    {
        private readonly FriendshipService service;
        private readonly MainForm mainForm;

        public SearchUC_P(FriendshipService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
        }
    }
}
