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
    public partial class PersonelKayitEkrani : Form
    {
        public PersonelKayitEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonelKayitEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adapter = new KutuphaneOtomasyonuDataSetTableAdapters.PersonelTableAdapter();
            adapter.Insert(
                txtTc.Text,
                txtAdSoyad.Text,
                comboYetkidurumu.Text,
                txtMail.Text);
            MessageBox.Show("Başarıyla Üye Kaydedildi");
            Temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtTc.Clear();
            txtAdSoyad.Clear();
            comboYetkidurumu.SelectedIndex = -1;
            txtMail.Clear();
        }

    }
}
