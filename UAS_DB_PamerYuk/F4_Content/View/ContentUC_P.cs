using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class ContentUC_P : UserControl
    {
        private readonly ContentService service;
        private readonly MainForm mainForm;

        public ContentUC_P(ContentService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void MultipleContentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
