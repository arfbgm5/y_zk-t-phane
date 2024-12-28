using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace y_zkütüphane
{
    public partial class s_c : Form
    {

        private yönetici Yönetici;
        public s_c()
        {
            InitializeComponent();
            ; // Yönetici formunu burada alıyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yönetici=new yönetici();

           string veri = dmtextBox1.Text; // TextBox'tan veriyi alıyoruz

            // Veriyi SQL Server'a kaydediyoruz
            Kaydetileti(veri);

            // Veriyi Yönetici Formu'ndaki ListBox'a ekliyoruz
            Yönetici.ListBoxaVeriEkle(veri);

        }

        // Veriyi SQL Server'a kaydetme metodu
        private void Kaydetileti(string veri)
        {
            string connectionString = "Server=localhost;" +
                                      "Database=yzcktp;" +
                                      "Uid=root;" +
                                      "Pwd=s0e9V8i7m6_55;" +
                                      "SslMode=none;";

            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO iletiler (ileti) VALUES (@ileti)";
                using (MySqlCommand cmd = new MySqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@ileti", veri);

                    try
                    {
                        baglan.Open();
                        cmd.ExecuteNonQuery(); // SQL komutunu çalıştır
                        MessageBox.Show("Mesajınız Başarıyla Gönderilmiştir !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }




    }
}
