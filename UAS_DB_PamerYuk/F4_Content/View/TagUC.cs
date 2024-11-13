using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class TagUC : UserControl
    {
        private readonly ContentService service;

        public TagUC(ContentService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void TagUC_Load(object sender, EventArgs e)
        {

        }
    }
}
