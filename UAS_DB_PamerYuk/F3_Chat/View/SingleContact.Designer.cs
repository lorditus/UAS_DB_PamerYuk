
namespace UAS_DB_PamerYuk.F3_Chat.View
{
    partial class SingleContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleContact));
            this.lblNamaKontak = new System.Windows.Forms.Label();
            this.pPictPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNamaKontak
            // 
            this.lblNamaKontak.AutoSize = true;
            this.lblNamaKontak.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNamaKontak.ForeColor = System.Drawing.Color.White;
            this.lblNamaKontak.Location = new System.Drawing.Point(80, 34);
            this.lblNamaKontak.Name = "lblNamaKontak";
            this.lblNamaKontak.Size = new System.Drawing.Size(103, 17);
            this.lblNamaKontak.TabIndex = 9;
            this.lblNamaKontak.Text = "Hasil Generate";
            // 
            // pPictPanel
            // 
            this.pPictPanel.BackColor = System.Drawing.Color.Transparent;
            this.pPictPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPictPanel.BackgroundImage")));
            this.pPictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPictPanel.Location = new System.Drawing.Point(4, 13);
            this.pPictPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pPictPanel.Name = "pPictPanel";
            this.pPictPanel.Size = new System.Drawing.Size(61, 57);
            this.pPictPanel.TabIndex = 7;
            // 
            // SingleContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNamaKontak);
            this.Controls.Add(this.pPictPanel);
            this.Name = "SingleContact";
            this.Size = new System.Drawing.Size(485, 74);
            this.Click += new System.EventHandler(this.SingleContact_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pPictPanel;
        public System.Windows.Forms.Label lblNamaKontak;
    }
}
