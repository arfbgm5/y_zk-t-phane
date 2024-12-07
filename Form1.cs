using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            string ku_adı = textBox1.Text;
            string sifree = textBox2.Text;



            MySqlConnection baglan = new MySqlConnection(
                   "Server='localhost';" +
                   "Database='yzcktp';" +
                   "Uid='root';" +
                   "Pwd='s0e9V8i7m6_55';");
            try
            {
                baglan.Open();

                // SQL sorgusu: Kullanıcı adı ve mail ile şifreyi kontrol et
                string query = @"SELECT COUNT(*) FROM g_kayıt WHERE k_adı = @Kullaniciadi  AND sifre = @Sifre";

                MySqlCommand cmd = new MySqlCommand(query, baglan);
                cmd.Parameters.AddWithValue("@Kullaniciadi", ku_adı);
                cmd.Parameters.AddWithValue("@Sifre", sifree);

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                // Kullanıcı doğrulama
                if (userCount > 0)
                {
                    // Giriş başarılı, ana ekrana geçiş yapılabilir
                    // Örnek: Ana formu açın
                    this.Hide(); // Mevcut formu gizleyin
                    Form2 asayfa = new Form2(); // Ana form örneği
                    asayfa.Show(); // Ana formu açın


                }

                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı, şifre veya mail.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // kayıtol oluştur aç
            kayıt_ol kayıt_ol = new kayıt_ol();
            this.Hide();
            kayıt_ol.ShowDialog();//sadece kayıtol formunda işlem yapmam izin verir
            this.Show();

        }
    }
}


    
           
