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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace y_zkütüphane
{
    public partial class gec : Form
    {
        private string ku_ad;
        public gec(string ku_adı)
        {
            InitializeComponent();
            ku_ad = ku_adı;//kullanıcı adını alıyoruz
            VeritabanindanKitaplariYukle();
        }
        private void VeritabanindanKitaplariYukle()
        {
            string connectionString = "Server=localhost;Database=yzcktp;Uid=root;Pwd=s0e9V8i7m6_55;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT gkitap_adi , gid, gtarih FROM gecmis WHERE gku_adi = @kullaniciAdi";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", ku_ad);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = Convert.ToInt32(reader["gid"]); // ID sütunu için
                            string kitapAdi = reader["gkitap_adi"].ToString(); // Kitap Adı sütunu için
                            string tarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Sistem tarihi
                            // ID'yi ilk sütuna ekle
                            ListViewItem item = new ListViewItem(id.ToString());

                            // Kitap Adını ikinci sütuna ekle
                            item.SubItems.Add(kitapAdi);

                            item.SubItems.Add(tarih);

                            // ListView'e ekle
                            listView1gecmis.Items.Add(item);
                           

                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//içi boş
        
      
            
        public void AddToListView(string kitapAdi, string yazar)
            {
              
            }//içleri boş

        private void gec_Load(object sender, EventArgs e)
        {
            // ListView sütunlarını ayarla
            listView1gecmis.View = View.Details;
            listView1gecmis.Columns.Add("ID", 80);
            listView1gecmis.Columns.Add("Kitap Adı", 150);
            listView1gecmis.Columns.Add("Tarih >< Saat", 150);


        }

        private void gec_FormClosing(object sender, FormClosingEventArgs e)
        {
        }//içi boş

        private void button1_Click(object sender, EventArgs e)//gecmiş silme buttonu
        {
            if (listView1gecmis.SelectedItems.Count > 0) // Seçili öğe var mı kontrol et
            {
                // Seçili öğenin ID'sini al
                string seciligecmisID = listView1gecmis.SelectedItems[0].Text; // Seçili öğenin ID'sini aldık (ilk sütun metni)

                if (!string.IsNullOrEmpty(seciligecmisID)) // Geçerli bir ID kontrolü
                {
                    try
                    {
                        // Veritabanı bağlantısını aç
                        MySqlConnection baglan = new MySqlConnection(
                            "Server='localhost';" +
                            "Database='yzcktp';" +
                            "Uid='root';" +
                            "Pwd='s0e9V8i7m6_55';");

                        baglan.Open();

                        // DELETE sorgusunu hazırla
                        string sql = "DELETE FROM gecmis WHERE gid = @id";
                        MySqlCommand komut = new MySqlCommand(sql, baglan);
                        komut.Parameters.AddWithValue("@id", seciligecmisID);

                        // Sorguyu çalıştır
                        int sonuc = komut.ExecuteNonQuery();

                        // Eğer bir kayıt silindiyse
                        if (sonuc > 0)
                        {
                            // ListView'den de sil
                            listView1gecmis.Items.RemoveAt(listView1gecmis.SelectedItems[0].Index); // Seçili öğeyi kaldır

                            MessageBox.Show("Geçmiş başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Geçmiş veritabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen geçerli bir öğe bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
