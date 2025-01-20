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
    public partial class KitapKaydıSilme : Form
    {
        public KitapKaydıSilme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void KitapKaydıSilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                string query = "SELECT * FROM Kitap WHERE 1=1";
                SqlCommand komut = new SqlCommand();

                
                if (!string.IsNullOrEmpty(txtKitapAdi.Text))
                {
                    query += " AND kitapadi LIKE @kitapadi";
                    komut.Parameters.AddWithValue("@kitapadi", "%" + txtKitapAdi.Text + "%");
                }

                
                if (!string.IsNullOrEmpty(txtBarkodNo.Text))
                {
                    query += " AND barkodno = @barkodno";
                    komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                }

                
                if (!string.IsNullOrEmpty(comboTuru.Text))
                {
                    query += " AND turu = @turu";
                    komut.Parameters.AddWithValue("@turu", comboTuru.Text);
                }

                
                if (!string.IsNullOrEmpty(txtYazar.Text))
                {
                    query += " AND yazari LIKE @yazari";
                    komut.Parameters.AddWithValue("@yazari", "%" + txtYazar.Text + "%");
                }

                
                komut.CommandText = query;
                komut.Connection = baglanti;

                
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
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                try
                {
                    
                    string barkodNo = dataGridView1.SelectedRows[0].Cells["barkodno"].Value.ToString();

                    
                    DialogResult result = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                    
                        using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                        {
                            baglanti.Open();

                    
                            string query = "DELETE FROM Kitap WHERE barkodno = @barkodno";
                            SqlCommand komut = new SqlCommand(query, baglanti);
                            komut.Parameters.AddWithValue("@barkodno", barkodNo);

                    
                            int affectedRows = komut.ExecuteNonQuery();

                    
                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Kitap başarıyla silindi.");
                                VeriYukle();
                            }
                            else
                            {
                                MessageBox.Show("Kitap silinemedi, lütfen tekrar deneyin.");
                            }
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
                MessageBox.Show("Lütfen silmek istediğiniz bir kitabı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void VeriYukle()
        {
            
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;"))
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Kitap"; 
                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklerken hata oluştu: " + ex.Message);
            }
        }
    }
}
