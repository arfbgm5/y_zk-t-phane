using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num= Convert.ToInt32(e_id.Text);
            String e_kitad = e_kadı.Text;
            string e_kon = e_konu.Text;
            string eyazar = e_yazar.Text;
            string eyay=e_yayın.Text;
            string edil = e_dil.Text;


            MySqlConnection bagla = new MySqlConnection(
                "Server='localhost';" +
                "Database='yzcktp';" +
                "Uid='root';" +
                "Pwd='s0e9V8i7m6_55';");

            try
            {
                bagla.Open();// Veritabanı bağlantısını açıyoruz
                string sql = " insert into kitap_ekle ( id, kitap_ad, konusu, yazar, yayın_evi, dil, metin )" +
                    "values (@kitapid,@KitapAdi, @Konusu, @Yazari, @YayinEvi, @Dil, @Metin)";

                MySqlCommand komut = new MySqlCommand(sql, bagla);

                // TextBox'lardan alınan bilgileri parametrelere ekliyoruz
                komut.Parameters.AddWithValue("@Kitapid", num);
                komut.Parameters.AddWithValue("@KitapAdi", e_kitad);
                komut.Parameters.AddWithValue("@Konusu", e_kon);
                komut.Parameters.AddWithValue("@Yazari", eyazar);
                komut.Parameters.AddWithValue("@YayinEvi", eyay);
                komut.Parameters.AddWithValue("@Dil", edil);
                komut.Parameters.AddWithValue("@Metin",textBox16.Text); // Uzun metin için

                // Sorguyu çalıştırıyoruz
                komut.ExecuteNonQuery();

                MessageBox.Show("Kitap başarıyla kaydedildi!");



               

            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapatıyoruz
                bagla.Close();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {// listele butonuna basıldığında veri tabanında bulunan kitapla ilgili bilgleri data grive çeker.
            MySqlConnection baglan = new MySqlConnection(
                "Server='localhost';" +
                "Database='yzcktp';" +
                "Uid='root';" +
                "Pwd='s0e9V8i7m6_55';");



            // SQL sorgusu
            string sqll = "SELECT id, kitap_ad, konusu, yazar, yayın_evi, dil  FROM kitap_ekle";

            // Veri çekme komutu
            using (MySqlCommand cmd = new MySqlCommand(sqll, baglan))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Verileri DataTable'a doldur
                DataTable table = new DataTable();
                adapter.Fill(table);

                // DataGridView'e verileri bağla
                dataGridView2.DataSource = table;
            }
        }

        private void button2_Click(object sender, EventArgs e)//güncellleme butonu
        {
            int gnum = Convert.ToInt32(textBox6.Text);
            String g_kitad = textBox10.Text;
            string g_kon = textBox9.Text;
            string gyazar = textBox8.Text;
            string gyay = textBox7.Text;
            string gdil = textBox2.Text;


            MySqlConnection baglan = new MySqlConnection(
               "Server='localhost';" +
               "Database='yzcktp';" +
               "Uid='root';" +
               "Pwd='s0e9V8i7m6_55';");

            try
            {
                baglan.Open();// Veritabanı bağlantısını açıyoruz
                string sql = "UPDATE kitap_ekle SET kitap_ad = @gKitapAdi, konusu = @gKonusu, " +
                 "yazar = @gYazari, yayın_evi = @gYayinEvi, dil = @gDil, metin = @gMetin WHERE id = @gID";

                MySqlCommand komut = new MySqlCommand(sql, baglan);

                // TextBox'lardan alınan bilgileri parametrelere ekliyoruz
                komut.Parameters.AddWithValue("@gID", gnum);
                komut.Parameters.AddWithValue("@gKitapAdi", g_kitad);
                komut.Parameters.AddWithValue("@gKonusu", g_kon);
                komut.Parameters.AddWithValue("@gYazari", gyazar);
                komut.Parameters.AddWithValue("@gYayinEvi", gyay);
                komut.Parameters.AddWithValue("@gDil", gdil);
                komut.Parameters.AddWithValue("@gMetin", textBox1.Text); // Uzun metin için

                // Sorguyu çalıştırıyoruz
                komut.ExecuteNonQuery();

                MessageBox.Show("Kitap başarıyla Güncellendi!");





            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapatıyoruz
                baglan.Close();
            }

        }

        private void dataGridView3g_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)//günclleme listeleme
        {
            // listele butonuna basıldığında veri tabanında bulunan kitapla ilgili bilgleri data grive çeker.
            MySqlConnection baglan = new MySqlConnection(
                "Server='localhost';" +
                "Database='yzcktp';" +
                "Uid='root';" +
                "Pwd='s0e9V8i7m6_55';");



            // SQL sorgusu
            string sqll = "SELECT id, kitap_ad, konusu, yazar, yayın_evi, dil  FROM kitap_ekle";

            // Veri çekme komutu
            using (MySqlCommand cmd = new MySqlCommand(sqll, baglan))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Verileri DataTable'a doldur
                DataTable table = new DataTable();
                adapter.Fill(table);

                // DataGridView'e verileri bağla
                dataGridView3g.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int snum = Convert.ToInt32(textBox6.Text);

            MySqlConnection baglan = new MySqlConnection(
               "Server='localhost';" +
               "Database='yzcktp';" +
               "Uid='root';" +
               "Pwd='s0e9V8i7m6_55';");



            try
            {
                baglan.Open();// Veritabanı bağlantısını açıyoruz
                string sql = "delete from kitap_ekle where @sID =id";

                MySqlCommand komut = new MySqlCommand(sql, baglan);

                // TextBox'lardan alınan bilgileri parametrelere ekliyoruz
                komut.Parameters.AddWithValue("@sID", snum);

                // Sorguyu çalıştırıyoruz
                komut.ExecuteNonQuery();

                MessageBox.Show("Kitap başarıyla Silindi!");

            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapatıyoruz
                baglan.Close();
            }

        }
    }
}
