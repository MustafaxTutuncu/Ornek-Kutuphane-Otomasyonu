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
    public partial class PersonelBilgileriGuncellemeEkrani : Form
    {
        public PersonelBilgileriGuncellemeEkrani()
        {
            InitializeComponent();
        }

        private void VeriYukle()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

            txtIsimArayıcı.Clear();
            txtArayici.Clear();
            dataGridView1.DataSource = null;

        }

        private void PersonelBilgileriGuncellemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                string query = "UPDATE Personel SET adsoyad = @adsoyad, yetkidurumu = @yetkidurumu,  email = @email WHERE tc = @tc";
                SqlCommand komut = new SqlCommand(query, baglanti);

                
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yetkidurumu", comboYetkidurumu.Text);
                komut.Parameters.AddWithValue("@email", txtMail.Text);

                
                int affectedRows = komut.ExecuteNonQuery();
                baglanti.Close();

                
                if (affectedRows > 0)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı!");
                
                    VeriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void Temizle()
        {
            txtTc.Clear();
            txtAdSoyad.Clear();
            comboYetkidurumu.SelectedIndex = -1; 
            txtMail.Clear();
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTc.Text = row.Cells["tc"].Value.ToString();
                txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
                comboYetkidurumu.Text = row.Cells["yetkidurumu"].Value.ToString();
                txtMail.Text = row.Cells["email"].Value.ToString();
            }
        }
    }
}
