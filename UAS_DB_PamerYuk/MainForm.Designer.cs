namespace UAS_DB_PamerYuk
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.chatButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 645);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.NavBar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.chatButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 55);
            this.panel1.TabIndex = 0;
            // 
            // profileButton
            // 
            this.profileButton.Image = global::UAS_DB_PamerYuk.Properties.Resources.ProfileButton;
            this.profileButton.Location = new System.Drawing.Point(298, 18);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(20, 20);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 3;
            this.profileButton.TabStop = false;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_OnClick);
            this.profileButton.MouseEnter += new System.EventHandler(this.ProfileButton_MouseEnter);
            this.profileButton.MouseLeave += new System.EventHandler(this.ProfileButton_MouseLeave);
            // 
            // chatButton
            // 
            this.chatButton.Image = global::UAS_DB_PamerYuk.Properties.Resources.ChatButton;
            this.chatButton.Location = new System.Drawing.Point(226, 18);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(20, 20);
            this.chatButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chatButton.TabIndex = 2;
            this.chatButton.TabStop = false;
            this.chatButton.Click += new System.EventHandler(this.ChatButton_OnClick);
            this.chatButton.MouseEnter += new System.EventHandler(this.ChatButton_MouseEnter);
            this.chatButton.MouseLeave += new System.EventHandler(this.ChatButton_MouseLeave);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Image = global::UAS_DB_PamerYuk.Properties.Resources.SearchButton;
            this.searchButton.Location = new System.Drawing.Point(154, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 20);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 1;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_OnClick);
            this.searchButton.MouseEnter += new System.EventHandler(this.SearchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Image = global::UAS_DB_PamerYuk.Properties.Resources.HomeButton_clicked;
            this.homeButton.Location = new System.Drawing.Point(82, 18);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(20, 20);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 0;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_OnClick);
            this.homeButton.MouseEnter += new System.EventHandler(this.HomeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PamerYuk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox chatButton;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}

