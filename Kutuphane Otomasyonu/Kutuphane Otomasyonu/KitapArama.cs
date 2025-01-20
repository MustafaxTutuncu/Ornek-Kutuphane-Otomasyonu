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
    public partial class KitapArama : Form
    {
        public KitapArama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void KitapArama_Load(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
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

                
                if (dt.Rows.Count == 1)
                {
                    txtRafNo.Text = dt.Rows[0]["rafno"].ToString();
                }
                else
                {
                    txtRafNo.Clear(); 
                }

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtBarkodNo.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            comboTuru.SelectedIndex = -1;
            txtRafNo.Clear();
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

