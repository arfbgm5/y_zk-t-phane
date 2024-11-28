using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace y_zkütüphane
{
    public partial class kullanıcı_giriş : Form
    {
        public kullanıcı_giriş()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2'yi oluşturup açıyoruz
            Form2 form2 = new Form2();
            this.Hide();  // Ana formu gizle
            form2.ShowDialog();  // Modal olarak form2'yi aç
            this.Show();  // Form2 kapandıktan sonra ana formu göster
        }
    }
}
