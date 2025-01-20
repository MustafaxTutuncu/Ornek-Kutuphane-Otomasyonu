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
        public partial class UyeBilgileriGuncelleme : Form
        {
            public UyeBilgileriGuncelleme()
            {
                InitializeComponent();
            }

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

            private void UyeBilgileriGuncelleme_Load(object sender, EventArgs e)
            {
                VeriYukle();
            }

            private void VeriYukle()
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uye", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtTc.Text = row.Cells["tc"].Value.ToString();
                    txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
                    txtYas.Text = row.Cells["yas"].Value.ToString();
                    comboCinsiyet.Text = row.Cells["cinsiyet"].Value.ToString();
                    txtTelefon.Text = row.Cells["telefon"].Value.ToString();
                    txtAdres.Text = row.Cells["adres"].Value.ToString();
                    txtMail.Text = row.Cells["email"].Value.ToString();
                    txtOkunanKitapSayisi.Text = row.Cells["okunankitapsayisi"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Geçerli bir satır seçiniz!");
                }
            }

            private void BtnArayici_Click(object sender, EventArgs e)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uye WHERE tc = @tc", baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@tc", txtArayici.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uye WHERE adsoyad = @adsoyad", baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@adsoyad", txtIsimArayıcı.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        baglanti.Open();

                        // Güncelleme sorgusu
                        string query = "UPDATE Uye SET tc = @newTc, adsoyad = @adsoyad, yas = @yas, cinsiyet = @cinsiyet, telefon = @telefon, adres = @adres, email = @email, okunankitapsayisi = @okunankitapsayisi WHERE tc = @oldTc";
                        SqlCommand komut = new SqlCommand(query, baglanti);

                        // Eski tc değeri
                        string eskiTcDegeri = dataGridView1.SelectedRows[0].Cells["tc"].Value.ToString();

                        // Parametre ekleme
                        komut.Parameters.AddWithValue("@oldTc", eskiTcDegeri);
                        komut.Parameters.AddWithValue("@newTc", txtTc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@yas", txtYas.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                        komut.Parameters.AddWithValue("@email", txtMail.Text);
                        komut.Parameters.AddWithValue("@okunankitapsayisi", Convert.ToInt32(txtOkunanKitapSayisi.Text));

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
                    else
                    {
                        MessageBox.Show("Lütfen bir satır seçin!");
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
                txtYas.Clear();
                comboCinsiyet.SelectedIndex = -1;
                txtTelefon.Clear();
                txtAdres.Clear();
                txtMail.Clear();
                txtOkunanKitapSayisi.Clear();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Temizle();
            }
        }
    }

