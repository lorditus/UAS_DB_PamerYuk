using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class SignInUC : UserControl
    {
        private readonly UserManagerService service;

        public SignInUC(UserManagerService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
