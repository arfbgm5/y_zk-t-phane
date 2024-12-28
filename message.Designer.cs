namespace y_zkütüphane
{
    partial class message
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
            this.y_g_mesaj = new System.Windows.Forms.ListBox();
            this.m_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // y_g_mesaj
            // 
            this.y_g_mesaj.FormattingEnabled = true;
            this.y_g_mesaj.ItemHeight = 16;
            this.y_g_mesaj.Location = new System.Drawing.Point(0, 2);
            this.y_g_mesaj.Name = "y_g_mesaj";
            this.y_g_mesaj.Size = new System.Drawing.Size(458, 436);
            this.y_g_mesaj.TabIndex = 0;
            // 
            // m_sil
            // 
            this.m_sil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.m_sil.Location = new System.Drawing.Point(171, 444);
            this.m_sil.Name = "m_sil";
            this.m_sil.Size = new System.Drawing.Size(144, 34);
            this.m_sil.TabIndex = 1;
            this.m_sil.Text = "Sil";
            this.m_sil.UseVisualStyleBackColor = false;
            this.m_sil.Click += new System.EventHandler(this.m_sil_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 479);
            this.Controls.Add(this.m_sil);
            this.Controls.Add(this.y_g_mesaj);
            this.Name = "message";
            this.Text = "message";
            this.Load += new System.EventHandler(this.message_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button m_sil;
        public System.Windows.Forms.ListBox y_g_mesaj;
    }
}