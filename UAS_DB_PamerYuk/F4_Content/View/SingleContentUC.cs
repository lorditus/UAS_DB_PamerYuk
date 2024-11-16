using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleContentUC : UserControl
    {
        private ContentService service;
        private readonly MainForm mainForm;

        public SingleContentUC(ContentService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void SingleContentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
