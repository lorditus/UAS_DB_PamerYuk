using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class SwitchUserUC : UserControl
    {
        private readonly UserManagerService service;

        public SwitchUserUC(UserManagerService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void SwitchUserUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
