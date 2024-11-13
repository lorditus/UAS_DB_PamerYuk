using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleContentUC : UserControl
    {
        private ContentService service;

        public SingleContentUC(ContentService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void SingleContentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
