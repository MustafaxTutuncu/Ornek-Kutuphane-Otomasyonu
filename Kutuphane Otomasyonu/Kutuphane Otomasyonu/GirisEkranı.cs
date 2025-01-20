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
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void GirisEkranı_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var kullaniciadi = txtKullaniciadi.Text;
            var kullanicipassword = txtKullanicipassword.Text;

            try
            {
            
                baglanti.Open();

            
                string sorgu = "SELECT COUNT(*) FROM Yetkililer WHERE kullaniciadi = @kullaniciadi AND kullanicipassword = @kullanicipassword";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

            
                komut.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                komut.Parameters.AddWithValue("@kullanicipassword", kullanicipassword);

            
                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {

                    Form1 anaEkran = new Form1();
                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
             
                baglanti.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKullaniciadi.Clear();
            txtKullanicipassword.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
