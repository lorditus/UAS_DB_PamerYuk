using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class MultipleContentUC : UserControl
    {
        private readonly ContentService service;

        public MultipleContentUC(ContentService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void MultipleContentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
