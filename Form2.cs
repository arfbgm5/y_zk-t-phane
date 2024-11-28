using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace y_zkütüphane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Ü_Click(object sender, EventArgs e)
        {
            // üzerimdekileri oluşturup açıyoruz
            üzerimdekiler üzerimdekiler  = new üzerimdekiler();
            üzerimdekiler.Show();  // üzerimdekileri göster
        }

        private void GEÇ_Click(object sender, EventArgs e)
        {// gec nesne  oluşturup açtık 
            gec gec = new gec();
            this.Hide();// form2yi  formu gizle 
            gec.ShowDialog();// modal olarak gec aç
            this.Show();// form2 yi gec kapanınca aç
        }

        private void list_Click(object sender, EventArgs e)
        {
            list list = new list();
            this.Hide();
            list.ShowDialog();
            this.Show();

        }

        private void İLET_Click(object sender, EventArgs e)
        {
            message message = new message();
            this.Hide();
            message.ShowDialog();
            this.Show();

        }

        private void D_M_Click(object sender, EventArgs e)
        {
            s_c s_c = new s_c();
            this.Hide();
            s_c.ShowDialog();
            this.Show();

        }

        private void ARA_Click(object sender, EventArgs e)
        {
            search search = new search();
            this.Hide();
            search.ShowDialog();
            this.Show();

        }
    }
}
