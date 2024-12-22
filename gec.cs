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
        public gec()
        {
            InitializeComponent();
        }
      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
      
            // Kitapları geçmiş listesine eklemek için metot
            public void AddToListView(string kitapAdi, string yazar)
            {
              // ListView'e kitap ve yazar bilgilerini ekliyoruz
              ListViewItem item = new ListViewItem(kitapAdi);
              item.SubItems.Add(yazar);
              listView1gecmis.Items.Add(item);
            }

        private void gec_Load(object sender, EventArgs e)
        {
            // ListView sütunlarını ayarla
            listView1gecmis.View = View.Details;
            listView1gecmis.Columns.Add("Kitap Adı", 150);
            listView1gecmis.Columns.Add("Yazar", 150);
        }

        private void gec_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapanırken sadece gizleniyor
            e.Cancel = true; // Kapanmayı engelle
            this.Hide();     // Sadece gizle
        }
    }
}
