using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class SignInUC : UserControl
    {
        private readonly UserManagerService service;
        private readonly MainForm mainForm;

        public SignInUC(UserManagerService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
        }
    }
}
