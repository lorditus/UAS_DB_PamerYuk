namespace UAS_DB_PamerYuk.F3_Chat.View
{
    partial class ChatListUC_P
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
            this.lblHeaderChat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeaderChat
            // 
            this.lblHeaderChat.AutoSize = true;
            this.lblHeaderChat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderChat.Location = new System.Drawing.Point(-3, 0);
            this.lblHeaderChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderChat.Name = "lblHeaderChat";
            this.lblHeaderChat.Size = new System.Drawing.Size(117, 32);
            this.lblHeaderChat.TabIndex = 4;
            this.lblHeaderChat.Text = "Chat | ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(0, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChatListUC_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHeaderChat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatListUC_P";
            this.Size = new System.Drawing.Size(533, 794);
            this.Load += new System.EventHandler(this.ChatListUC_P_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHeaderChat;
        public System.Windows.Forms.TextBox textBox1;
    }
}
