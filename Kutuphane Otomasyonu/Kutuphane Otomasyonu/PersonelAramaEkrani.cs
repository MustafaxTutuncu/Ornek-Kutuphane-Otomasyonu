using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class PersonelAramaEkrani : Form
    {
        public PersonelAramaEkrani()
        {
            InitializeComponent();
        }

        private void BtnArayici_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Personel WHERE tc = @tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtArayici.Text);

                
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dataGridView1.DataSource = dt;

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Personel WHERE adsoyad = @adsoyad", baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtIsimArayıcı.Text);

                
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dataGridView1.DataSource = dt;

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIsimArayıcı.Clear();
            txtArayici.Clear();
            dataGridView1.DataSource = null;
        }
    }
}
