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
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
        }
        
        private void kayıt_ol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // girilen bilgilerin veri tabanına kaydı
            string e_posta = textBox1.Text;
            string k_adı = textBox2.Text;
            string sifre = textBox3.Text;
            string rol = "user";


            try
            { 
                MySqlConnection baglan = new MySqlConnection(
                    "Server='localhost';" +
                    "Database='yzcktp';" +
                    "Uid='root';" +
                    "Pwd='s0e9V8i7m6_55';");

                {
                    baglan.Open();
                    string kontrl = $"SELECT COUNT(*) FROM g_kayıt WHERE e_post = @Eposta;";
                    MySqlCommand control = new MySqlCommand(kontrl, baglan);
                    {
                        control.Parameters.AddWithValue("@Eposta", e_posta);
                        // Sorguyu çalıştır ve sonucu al
                        int count = Convert.ToInt32(control.ExecuteScalar());
                        baglan.Close();

                        if (count > 0)
                        {
                            // E-posta veritabanında bulundu
                            MessageBox.Show($"Bir hata oluştu:E postanız zaten kayıtlı! başka bir e posta deneyin");
                        }
                    

                    }
                    baglan.Open() ;
                    string sql = $"insert into g_kayıt(e_post, k_adı, sifre) values(@Eposta,@KullaniciAdi,@Sifre)";
                    using(MySqlCommand komut = new MySqlCommand(sql, baglan))
                    {
                        komut.Parameters.AddWithValue("@Eposta", e_posta);
                        komut.Parameters.AddWithValue("@KullaniciAdi", k_adı);
                        komut.Parameters.AddWithValue("@Sifre", sifre);
                        komut.ExecuteNonQuery();// Sorguyu çalıştır

                        // Kayıt başarılıysa mesaj göster
                        MessageBox.Show("Kayıt işlemi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
              
            }
            
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }



        }
    }
}
