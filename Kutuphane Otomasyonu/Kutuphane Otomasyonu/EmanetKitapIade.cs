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
    public partial class EmanetKitapIade : Form
    {
        public EmanetKitapIade()
        {
            InitializeComponent();
        }


        private void EmanetKitapIade_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnArayici_Click(object sender, EventArgs e)
        {

        }
        private void VeriYukle()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Emanet", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) 
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                     
                        string tc = dataGridView1.SelectedRows[0].Cells["tc"].Value.ToString();

                        DialogResult result = MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                            baglanti.Open();

                            string query = "DELETE FROM Emanet WHERE tc = @tc";
                            SqlCommand komut = new SqlCommand(query, baglanti);
                            komut.Parameters.AddWithValue("@tc", tc);

                            int affectedRows = komut.ExecuteNonQuery();
                            baglanti.Close();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Üye başarıyla silindi.");
                                VeriYukle(); 
                            }
                            else
                            {
                                MessageBox.Show("Üye silinemedi, lütfen tekrar deneyin.");
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
                    MessageBox.Show("Lütfen silmek istediğiniz bir üyeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void BtnArayici_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Emanet WHERE tc = @tc", baglanti);
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

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Emanet WHERE adsoyad = @adsoyad", baglanti);
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
    }

}

