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
    public partial class PersonelYetkilendirmeEkrani : Form
    {
        public PersonelYetkilendirmeEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtArayici.Clear();
            dataGridView1.DataSource = null;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboYetkidurumu.Text = row.Cells["yetkidurumu"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                {
                    baglanti.Open();

                    
                    string updateQuery = "UPDATE Personel SET yetkidurumu = @yetkidurumu WHERE tc = @tc";
                    SqlCommand updateKomut = new SqlCommand(updateQuery, baglanti);
                    updateKomut.Parameters.AddWithValue("@yetkidurumu", comboYetkidurumu.Text);
                    updateKomut.Parameters.AddWithValue("@tc", txtArayici.Text);
                    updateKomut.ExecuteNonQuery();

                    
                    string insertQuery = "INSERT INTO Yetkililer (tc, kullaniciadi, kullanicipassword) VALUES (@tc, @kullaniciadi, @kullanicipassword)";
                    SqlCommand insertKomut = new SqlCommand(insertQuery, baglanti);

                   
                    insertKomut.Parameters.AddWithValue("@tc", txtArayici.Text);  
                    insertKomut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdiSoyadi.Text);
                    insertKomut.Parameters.AddWithValue("@kullanicipassword", txtKullaniciPassword.Text);
                    insertKomut.ExecuteNonQuery();

                    MessageBox.Show("Personele başarı ile yetki verildi ve şifresi sisteme kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtArayici.Clear();
            txtKullaniciAdiSoyadi.Clear();
            txtKullaniciPassword.Clear();
            comboYetkidurumu.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }
    }
}