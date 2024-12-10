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
                // Veritabanı bağlantısını açıyoruz
                baglan.Open();

                // E-posta ve şifreyi kontrol eden SQL sorgusu
                string kontrl = "SELECT COUNT(*), rol FROM g_kayıt WHERE k_adı = @KullaniciAdi AND sifre = @Sifre GROUP BY rol"; ;
                MySqlCommand control = new MySqlCommand(kontrl, baglan);
                control.Parameters.AddWithValue("@KullaniciAdi", ku_adı);
                control.Parameters.AddWithValue("@Sifre", sifree);

                // Sorguyu çalıştır ve sonucu al
                MySqlDataReader reader = control.ExecuteReader();

                if (reader.Read()) // Veritabanından veri okundu
                {
                    int count = reader.GetInt32(0); // E-posta ve şifreyi kontrol et
                    string rol = reader.GetString(1); // Admin kontrolü (string olarak)

                    if (count > 0) // E-posta ve şifre doğruysa
                    {
                        // Admin kontrolü
                        if (rol == "admin") // Eğer adminse
                        {
                            MessageBox.Show("Giriş başarılı, yönetici sayfasına yönlendiriliyorsunuz.");
                            this.Hide();  // Ana formu gizle
                            yönetici yönet = new yönetici(); // Yönetici formu
                            yönet.Show(); // Yönetici formunu göster
                        }
                        else if (rol == "user") // Eğer normal kullanıcıysa
                        {
                            MessageBox.Show("Giriş başarılı, kullanıcı sayfasına yönlendiriliyorsunuz.");
                            // Normal kullanıcı sayfasına yönlendirme yapılabilir.
                            this.Hide();
                            Form2 anae=new Form2();
                            anae.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası veya kullanıcı bulunamadı.");
                }

                // Veritabanı bağlantısını kapat
                baglan.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    
           
