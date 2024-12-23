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
            this.listbox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbox2
            // 
            this.listbox2.FormattingEnabled = true;
            this.listbox2.ItemHeight = 16;
            this.listbox2.Location = new System.Drawing.Point(0, 2);
            this.listbox2.Name = "listbox2";
            this.listbox2.Size = new System.Drawing.Size(459, 452);
            this.listbox2.TabIndex = 0;
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 473);
            this.Controls.Add(this.listbox2);
            this.Name = "message";
            this.Text = "message";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox2;
    }
}