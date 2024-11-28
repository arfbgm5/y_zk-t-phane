namespace y_zkütüphane
{
    partial class kullanıcı_giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.GİRİŞ = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GİRİŞ.SuspendLayout();
            this.SuspendLayout();
            // 
            // GİRİŞ
            // 
            this.GİRİŞ.BackColor = System.Drawing.Color.Black;
            this.GİRİŞ.Controls.Add(this.label3);
            this.GİRİŞ.Controls.Add(this.button2);
            this.GİRİŞ.Controls.Add(this.button1);
            this.GİRİŞ.Controls.Add(this.textBox2);
            this.GİRİŞ.Controls.Add(this.label2);
            this.GİRİŞ.Controls.Add(this.label1);
            this.GİRİŞ.Controls.Add(this.textBox1);
            this.GİRİŞ.Cursor = System.Windows.Forms.Cursors.No;
            this.GİRİŞ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GİRİŞ.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GİRİŞ.Location = new System.Drawing.Point(272, 95);
            this.GİRİŞ.Name = "GİRİŞ";
            this.GİRİŞ.Size = new System.Drawing.Size(285, 330);
            this.GİRİŞ.TabIndex = 0;
            this.GİRİŞ.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(91, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "GİRİŞ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Çıkış yap";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(32, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 159);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞİFRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kullanıcı_giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::y_zkütüphane.Properties.Resources.WhatsApp_Görsel_2024_09_27_saat_14_07_50_0361857c;
            this.ClientSize = new System.Drawing.Size(796, 510);
            this.Controls.Add(this.GİRİŞ);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "kullanıcı_giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI_GİRİŞ";
            this.GİRİŞ.ResumeLayout(false);
            this.GİRİŞ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GİRİŞ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

