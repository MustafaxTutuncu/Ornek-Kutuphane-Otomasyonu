using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class PersonelYetkisizlendirmeEkrani : Form
    {
        public PersonelYetkisizlendirmeEkrani()
        {
            InitializeComponent();
        }

        
        private void BtnArayici_Click(object sender, EventArgs e)
        {
            try
            {
        
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                {
                    baglanti.Open();

        
                    SqlCommand komut = new SqlCommand("SELECT * FROM Yetkililer WHERE tc = @tc", baglanti);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);

        
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

        
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
        
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                try
                {
                    string tc = dataGridView1.SelectedRows[0].Cells["tc"].Value.ToString();

                    
                    DialogResult result = MessageBox.Show("Personeli yetkisizleştirmek ve silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                    
                        using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                        {
                            baglanti.Open();

                    
                            SqlCommand guncelleKomutu = new SqlCommand("UPDATE Personel SET yetkidurumu = 'Yetkisiz' WHERE tc = @tc", baglanti);
                            guncelleKomutu.Parameters.AddWithValue("@tc", tc);
                            guncelleKomutu.ExecuteNonQuery();

                    
                            SqlCommand silKomutu = new SqlCommand("DELETE FROM Yetkililer WHERE tc = @tc", baglanti);
                            silKomutu.Parameters.AddWithValue("@tc", tc);
                            silKomutu.ExecuteNonQuery();

                            MessageBox.Show("Personel yetkisizleştirildi ve Yetkililer tablosundan silindi.");

                    
                            VeriYukle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VeriYukle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Yetkililer", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
