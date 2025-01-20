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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
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
            var adapter = new KutuphaneOtomasyonuDataSetTableAdapters.UyeTableAdapter();  
            adapter.Insert(
                txtTc.Text,
                txtAdSoyad.Text,
                txtYas.Text,
                comboCinsiyet.Text,
                txtTelefon.Text,
                txtAdres.Text,
                txtMail.Text,
                Convert.ToInt32(txtOkunanKitapSayisi.Text)
            );
            MessageBox.Show("Başarıyla Üye Kaydedildi");
            Temizle();
            
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            txtTc.Clear();
            txtAdSoyad.Clear();
            txtYas.Clear();
            comboCinsiyet.SelectedIndex = -1; 
            txtTelefon.Clear();
            txtAdres.Clear();
            txtMail.Clear();
            txtOkunanKitapSayisi.Clear();
        }

    }
}
