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
    public partial class KitapBilgilerininGuncellenmesi : Form
    {
        public KitapBilgilerininGuncellenmesi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void KitapBilgilerininGuncellenmesi_Load(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            txtBarkodNoN.Clear();
            txtKitapAdiN.Clear();
            txtYazarN.Clear();
            comboTuruN.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void Temizlendi()
        {
            txtBarkodNo.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayınEvi.Clear();
            txtSayfaSayisi.Clear();
            comboTuru.SelectedIndex = -1;
            txtStokSayisi.Clear();
            txtRafNo.Clear();
            txtAciklama.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSayfaSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizlendi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                
                txtBarkodNo.Text = row.Cells["barkodno"].Value.ToString();
                txtKitapAdi.Text = row.Cells["kitapadi"].Value.ToString();
                txtYazar.Text = row.Cells["yazari"].Value.ToString();
                comboTuru.SelectedItem = row.Cells["turu"].Value.ToString();
                txtYayınEvi.Text = row.Cells["yayinevi"].Value.ToString();
                txtSayfaSayisi.Text = row.Cells["sayfasayisi"].Value.ToString();
                txtStokSayisi.Text = row.Cells["stoksayisi"].Value.ToString();
                txtRafNo.Text = row.Cells["rafno"].Value.ToString();
                txtAciklama.Text = row.Cells["aciklama"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();

                
                string query = "UPDATE Kitap SET kitapadi = @kitapadi, yazari = @yazari, yayinevi = @yayinevi, sayfasayisi = @sayfasayisi, turu = @turu, stoksayisi = @stoksayisi, rafno = @rafno, aciklama = @aciklama WHERE barkodno = @barkodno";
                SqlCommand komut = new SqlCommand(query, baglanti);

                
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayınEvi.Text);
                komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@turu", comboTuru.SelectedItem);
                komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
                komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);

                
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap bilgileri başarıyla güncellendi!");

                baglanti.Close();
                Temizlendi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRafNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtStokSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtYayınEvi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
