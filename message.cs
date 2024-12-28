using MySql.Data.MySqlClient;
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
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }
        public static class CurrentUser
        {
            public static string Email { get; set; }
        }
       
        private string userEmail;

        public message(string email)
        {
            InitializeComponent();
            userEmail = email; // Kullanıcı e-posta adresini al
            LoadUserMessages(); // Mesajları yükle
        }

        private void LoadUserMessages()
        {
            string connectionString = "Server='localhost';" +
                                      "Database='yzcktp';" +
                                      "Uid='root';" +
                                      "Pwd='s0e9V8i7m6_55';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT mesaj FROM mesaj WHERE kmail = @UserEmail";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserEmail", userEmail);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        y_g_mesaj.Items.Add(reader["mesaj"].ToString());
                    }
                }
            }
        }


        private void m_sil_Click(object sender, EventArgs e)//message formunda bulunan yöneticidden gelen mesajları silme
        {
            string gelenmesaj=y_g_mesaj.SelectedItem.ToString();//seçili ogeyi gelenmesaja at

            if(!string.IsNullOrEmpty(gelenmesaj) )//secim yapılmışmı kontrol et
            {
                // Veritabanı bağlantısını aç
                MySqlConnection baglan = new MySqlConnection(
                          "Server='localhost';" +
                             "Database='yzcktp';" +
                           "Uid='root';" +
                             "Pwd='s0e9V8i7m6_55';");
                {
                    baglan.Open();
                    //veri tabanından silme sorgusu
                    string sql = "delete from mesaj where mesaj=@mesajj";
                    MySqlCommand komut=new MySqlCommand(sql, baglan);
                    komut.Parameters.AddWithValue("@mesajj", gelenmesaj);


                    // Sorguyu çalıştır
                    int sonucu = komut.ExecuteNonQuery();


                    // Eğer bir kayıt silindiyse (0 ise hiçbir şey silinmemiş demektir)
                    if(sonucu > 0)
                    {
                        //y_g_mesaj(listbox) tandasil
                        y_g_mesaj.Items.RemoveAt(y_g_mesaj.SelectedIndex);
                        MessageBox.Show("Seçilen metin başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçilen metin bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir metin seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
       


        private void message_Load(object sender, EventArgs e)
        {
             
        }
    }
}
