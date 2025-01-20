using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyonu
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adapter = new KutuphaneOtomasyonuDataSetTableAdapters.KitapTableAdapter();
            adapter.Insert(
                txtBarkodNo.Text,
                txtKitapAdi.Text,
                txtYazar.Text,
                txtYayınEvi.Text,
                txtSayfaSayisi.Text,
                comboTuru.Text,
                Convert.ToInt32(txtStokSayisi.Text),
                txtRafNo.Text,
                txtAciklama.Text);
            MessageBox.Show("Kitap Başarıyla Kaydedildi");
            Temizle();
        }


        private void Temizle()
        {
            txtBarkodNo.Clear(); 
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayınEvi.Clear();
            txtSayfaSayisi.Clear();
            comboTuru.SelectedIndex = -1;
            txtStokSayisi.Clear();
            txtRafNo.Clear();
            txtAciklama.Clear();
        }



        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
