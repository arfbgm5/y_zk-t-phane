namespace y_zkütüphane
{
    partial class s_c
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
            this.button1 = new System.Windows.Forms.Button();
            this.dmtextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dmtextBox1
            // 
            this.dmtextBox1.Location = new System.Drawing.Point(-2, 12);
            this.dmtextBox1.Multiline = true;
            this.dmtextBox1.Name = "dmtextBox1";
            this.dmtextBox1.Size = new System.Drawing.Size(433, 284);
            this.dmtextBox1.TabIndex = 1;
            // 
            // s_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 361);
            this.Controls.Add(this.dmtextBox1);
            this.Controls.Add(this.button1);
            this.Name = "s_c";
            this.Text = "s_c";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dmtextBox1;
    }
}