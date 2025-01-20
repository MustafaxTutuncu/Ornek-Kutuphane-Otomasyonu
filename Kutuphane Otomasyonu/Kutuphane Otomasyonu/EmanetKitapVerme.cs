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
    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }

        private void EmanetKitapVerme_Load(object sender, EventArgs e)
        {

        }

        private void BtnArayici_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    string tc = row.Cells["tc"].Value.ToString();
                    string adsoyad = row.Cells["adsoyad"].Value.ToString();
                    string telefon = row.Cells["telefon"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();
                    string barkodno = txtBarkodNo.Text;
                    string kitapadi = txtKitapAdi.Text;
                    string yazari = txtYazar.Text;
                    string yayinevi = txtYayınEvi.Text;
                    string teslimTarihi = txtTeslimtarihi.Text;
                    string iadeTarihi = txtIadetarihi.Text;

                    
                    string query = "INSERT INTO Emanet (tc, adsoyad, telefon, email, barkodno, kitapadi, yazari, yayinevi, teslimtarihi, iadetarihi) " +
                                   "VALUES (@tc, @adsoyad, @telefon, @email, @barkodno, @kitapadi, @yazari, @yayinevi, @teslimtarihi, @iadetarihi)";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@adsoyad", adsoyad);
                    komut.Parameters.AddWithValue("@telefon", telefon);
                    komut.Parameters.AddWithValue("@email", email);
                    komut.Parameters.AddWithValue("@barkodno", barkodno);
                    komut.Parameters.AddWithValue("@kitapadi", kitapadi);
                    komut.Parameters.AddWithValue("@yazari", yazari);
                    komut.Parameters.AddWithValue("@yayinevi", yayinevi);
                    komut.Parameters.AddWithValue("@teslimtarihi", teslimTarihi);
                    komut.Parameters.AddWithValue("@iadetarihi", iadeTarihi);

                    
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Emanet kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BtnArayici_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
                baglanti.Open();

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Uye WHERE tc = @tc", baglanti);
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

                
                SqlCommand komut = new SqlCommand("SELECT * FROM Uye WHERE adsoyad = @adsoyad", baglanti);
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

        private void button3_Click(object sender, EventArgs e)
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

                
                if (!string.IsNullOrEmpty(comboTuruN.Text))
                {
                    query += " AND turu = @turu";
                    komut.Parameters.AddWithValue("@turu", comboTuruN.Text);
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
                dataGridView2.DataSource = dt;

               
                
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

        private void button4_Click(object sender, EventArgs e)
        {
            txtBarkodNoN.Clear();
            txtKitapAdiN.Clear();
            txtYazarN.Clear();
            comboTuruN.SelectedIndex = -1;
            dataGridView2.DataSource = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                
                txtBarkodNo.Text = row.Cells["barkodno"].Value.ToString();
                txtKitapAdi.Text = row.Cells["kitapadi"].Value.ToString();
                txtYazar.Text = row.Cells["yazari"].Value.ToString();
                txtYayınEvi.Text = row.Cells["yayinevi"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTc.Text = row.Cells["tc"].Value.ToString();
                txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
                txtTelefon.Text = row.Cells["telefon"].Value.ToString();
                txtMail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void txtVeris_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTc.Clear(); 
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBarkodNo.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayınEvi.Clear();
        }

        private void Temizle()
        {
            txtTeslimtarihi.Clear();
            txtIadetarihi.Clear();
        }
    }
}
