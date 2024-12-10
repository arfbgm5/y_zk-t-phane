using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace y_zkütüphane
{
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection(
                  "Server='localhost';" +
                  "Database='yzcktp';" +
                  "Uid='root';" +
                  "Pwd='s0e9V8i7m6_55';");
            baglan.Open();
            string sql = "select * from g_kayıt";
            MySqlDataAdapter veri =new MySqlDataAdapter(sql,baglan);
            DataTable tablo= new DataTable();
            veri.Fill(tablo);
            dataGridView1. DataSource = tablo;
            baglan.Close();
        }
    }
}
