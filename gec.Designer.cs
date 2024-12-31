namespace y_zkütüphane
{
    partial class gec
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
            this.listView1gecmis = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(465, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1gecmis
            // 
            this.listView1gecmis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1gecmis.HideSelection = false;
            this.listView1gecmis.Location = new System.Drawing.Point(2, -1);
            this.listView1gecmis.Name = "listView1gecmis";
            this.listView1gecmis.Size = new System.Drawing.Size(457, 581);
            this.listView1gecmis.TabIndex = 2;
            this.listView1gecmis.UseCompatibleStateImageBehavior = false;
            this.listView1gecmis.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // gec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 580);
            this.Controls.Add(this.listView1gecmis);
            this.Controls.Add(this.button1);
            this.Name = "gec";
            this.Text = "gec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gec_FormClosing);
            this.Load += new System.EventHandler(this.gec_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1gecmis;
    }
}