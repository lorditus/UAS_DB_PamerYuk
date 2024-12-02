namespace UAS_DB_PamerYuk.F4_Content.View
{
    partial class HomeMenuUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notificationButton = new System.Windows.Forms.PictureBox();
            this.addContentButton = new System.Windows.Forms.PictureBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.NotificationButton;
            this.notificationButton.Location = new System.Drawing.Point(80, 15);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(287, 50);
            this.notificationButton.TabIndex = 1;
            this.notificationButton.TabStop = false;
            // 
            // addContentButton
            // 
            this.addContentButton.BackgroundImage = global::UAS_DB_PamerYuk.Properties.Resources.AddContentButton;
            this.addContentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addContentButton.Location = new System.Drawing.Point(15, 15);
            this.addContentButton.Name = "addContentButton";
            this.addContentButton.Size = new System.Drawing.Size(50, 50);
            this.addContentButton.TabIndex = 0;
            this.addContentButton.TabStop = false;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.Location = new System.Drawing.Point(142, 34);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(141, 13);
            this.notificationLabel.TabIndex = 2;
            this.notificationLabel.Text = "No Notifications Found!";
            // 
            // HomeMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.addContentButton);
            this.Name = "HomeMenuUC";
            this.Size = new System.Drawing.Size(382, 80);
            this.Load += new System.EventHandler(this.HomeMenuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContentButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addContentButton;
        private System.Windows.Forms.PictureBox notificationButton;
        private System.Windows.Forms.Label notificationLabel;
    }
}
