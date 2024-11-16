using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class AddContentUC : UserControl
    {
        private readonly ContentService service;
        private readonly MainForm mainForm;

        public AddContentUC(ContentService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void AddContentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
