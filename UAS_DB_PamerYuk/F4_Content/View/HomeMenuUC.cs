using System;
using System.Drawing;
using System.Windows.Forms;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class HomeMenuUC : UserControl
    {

        private bool isTyping;

        public HomeMenuUC()
        {
            InitializeComponent();
            isTyping = false;
        }

        private void HomeMenuUC_Load(object sender, EventArgs e)
        {
            captionTextBox.BackColor = ColorUtil.palette["dim-white"];
            this.ActiveControl = notificationButton;
            sendLabel.BackColor = ColorUtil.palette["charcoal-gray"];
            sendLabel.ForeColor = ColorUtil.palette["peach-cream"];
        }

        private void captionTextBox_Click(object sender, EventArgs e)
        {
            if (captionTextBox.Text == "Write your caption here...")
            {
                captionTextBox.Text = "";
                captionTextBox.ForeColor = Color.Black;
            }
        }

        private void captionTextBox_Leave(object sender, EventArgs e)
        {
            if (captionTextBox.Text == "")
            {
                captionTextBox.Text = "Write your caption here...";
                captionTextBox.ForeColor = ColorUtil.palette["light-grey"];
            }
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {

        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
