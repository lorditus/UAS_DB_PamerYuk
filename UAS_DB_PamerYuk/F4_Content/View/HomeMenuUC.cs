using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class HomeMenuUC : UserControl
    {
        public HomeMenuUC()
        {
            InitializeComponent();
        }

        private void HomeMenuUC_Load(object sender, EventArgs e)
        {
            notificationLabel.BackColor = ColorUtil.palette["peach-cream"];
            notificationLabel.ForeColor = ColorUtil.palette["charcoal-gray"];
        }
    }
}
