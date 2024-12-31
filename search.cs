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
    public partial class search : Form
    {
        // Geçmiş formunu saklamak için global değişken
        public static gec gecForm; // Geçmiş formunu global olarak tanımlıyoruz
        private string ku_ad;
        public search(string ku_adı)
        {
            InitializeComponent();
           ku_ad = ku_adı;//kullanıcı adı alınıyor
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ara butonuna basıldığında datagriveve metinde yazılı olan kitaplar gelir
        {

            string k_ara = textBox1.Text;
            MySqlConnection baglan = new MySqlConnection(
               "Server='localhost';" +
               "Database='yzcktp';" +
               "Uid='root';" +
               "Pwd='s0e9V8i7m6_55';");


            try
            {
                // Veritabanı bağlantısını aç
                baglan.Open();

                // Arama yapmak için SQL sorgusu
                string sql = "SELECT * FROM kitap_ekle WHERE kitap_ad LIKE @KitapAdi";

                // SQL komutunu oluştur
                MySqlCommand komut = new MySqlCommand(sql, baglan);

                // TextBox'tan kitap adı al ve parametreye ekle
                komut.Parameters.AddWithValue("@KitapAdi", "%" + k_ara + "%");

                // Sorgu sonuçlarını DataTable'a doldur
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView'e veriyi bağla
                dataGridView1.DataSource = dt;

                // Mesaj göster (isteğe bağlı)
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Aradığınız kitap bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                baglan.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//ara formunda bululnan dtagriwide seçilen 
        {
            // Geçerli satırda bir hücre seçildiğinde
            if (e.RowIndex >= 0)
            {
                // Seçilen satırın verilerini al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // "metin" sütunundaki değeri TextBox'a aktar
                textBox2.Text = row.Cells["metin"].Value.ToString();

                // TabPage 2'yi aktif hale getir
                tabControl1.SelectedTab = tabPage2;
            }




            //datagrivedeki veriyi gec formundaki kullancıadı ve ve kitap adini gecmis tablosuna ekledik
            if (e.RowIndex >= 0)
            {
                string kitapBilgisi = dataGridView1.Rows[e.RowIndex].Cells["kitap_ad"].Value.ToString();

                string connectionString = "Server=localhost;Database=yzcktp;Uid=root;Pwd=s0e9V8i7m6_55;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO gecmis (gku_adi, gkitap_adi) VALUES (@kullaniciAdi, @kitapAdi)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", ku_ad);
                        command.Parameters.AddWithValue("@kitapAdi", kitapBilgisi);
                        command.ExecuteNonQuery();
                    }
                }

              
            }


        }
    }
}
