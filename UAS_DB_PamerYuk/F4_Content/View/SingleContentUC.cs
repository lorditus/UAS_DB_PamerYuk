using MySql.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleContentUC : UserControl
    {
        private readonly ContentService service;
        private readonly Panel panel;

        public SingleContentUC(ContentService service, Panel panel)
        {
            InitializeComponent();
            this.service = service;
            this.panel = panel;
        }

        private void SingleContentUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];

            int descHeight = TextRenderer.MeasureText(label_desc.Text, label_desc.Font).Height * ((label_desc.Text.Length / 70 + 1));
            label_desc.Size = new Size(350, descHeight);

            int postedOnPositionY = label_desc.Location.Y + label_desc.Size.Height + 6;
            label_postedOn.Location = new Point(label_postedOn.Location.X, postedOnPositionY);

            panel.Size = new Size(panel.Size.Width, panel.Size.Height + descHeight - 1);
            this.Size = new Size(this.Size.Width, this.Size.Height + descHeight - 1);
        }

        private void On_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void setTestSample(int index)
        {
            if (index == 2)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser2;
                contentPictBox.Image = Properties.Resources.sampleContent2;
                usernameLabel.Text = "eunwo.o_c";
                label_desc.Text = "With the soft patter of rain against the window, they settled into their favorite chair, " +
                    "cradling a freshly made egg mayo sandwich. The creamy blend of eggs and mayonnaise, nestled between " +
                    "perfectly toasted bread, felt like the ultimate comfort on this gray afternoon. Outside, the rain " +
                    "painted the world in hues of silver and green, each droplet a tiny symphony on the glass. As they took " +
                    "a bite, the richness of the sandwich harmonized with the calming rhythm of the storm. The air smelled " +
                    "of rain-soaked earth, mingling with the warmth of the kitchen—a perfect pairing. Sometimes, the " +
                    "simplest pleasures, like a good sandwich and a rainy day, create the most unforgettable moments.";
            } else if (index == 3)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser4;
                contentPictBox.Image = Properties.Resources.sampleContent4;
                usernameLabel.Text = "skuukzky";
                label_desc.Text = "...";
            } else if (index == 4)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser5;
                contentPictBox.Image = Properties.Resources.sampleContent3;
                usernameLabel.Text = "xeesoxee";
                label_desc.Text = "Embracing the summer vibes through the day!";
            } else if (index == 5)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser3;
                contentPictBox.Image = Properties.Resources.sampleContent5;
                usernameLabel.Text = "donlee";
                label_desc.Text = "After a midnight showdown.";
            }
        }
    }
}
