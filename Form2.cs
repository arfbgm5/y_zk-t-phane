using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
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
        { // Eğer geçmiş formu bellekte yoksa, yeni bir nesne oluşturulur
            if (search.gecForm == null || search.gecForm.IsDisposed)
            {
                search.gecForm = new gec(); // Formu oluştur (eğer kapatıldıysa)
            }

            // Geçmiş Formunu göster
            search.gecForm.Show();
            search.gecForm.BringToFront(); // Formu ön plana getir
        }
    

        private void list_Click(object sender, EventArgs e)
        {
            list list = new list();
            this.Hide();
            list.ShowDialog();
            this.Show();

        }//ileti mesajını tutumak için
        private string ku_adı; // Kullanıcı adı için değişken

        public Form2(string username)
        {
            InitializeComponent();
            ku_adı = username; // Kullanıcı adını al
        }
        private void İLET_Click(object sender, EventArgs e)
        {
            string userEmail = GetUserEmailByUsername(ku_adı);

            if (!string.IsNullOrEmpty(userEmail))
            {
                // message formunu aç ve kullanıcı e-posta adresini gönder
                message mesajForm = new message(userEmail);
                mesajForm.Show();
            }
            else
            {
                MessageBox.Show("E-posta bulunamadı. Kullanıcı adı hatalı olabilir.");
            }
        }

        private string GetUserEmailByUsername(string ku_adı)
        {
            string userEmail = null;
            string connectionString = "Server='localhost';" +
                                      "Database='yzcktp';" +
                                      "Uid='root';" +
                                      "Pwd='s0e9V8i7m6_55';";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e_post FROM g_kayıt WHERE k_adı = @Username";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", ku_adı);
                        userEmail = command.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

            return userEmail;



          

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
