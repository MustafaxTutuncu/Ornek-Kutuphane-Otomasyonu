using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kutuphane_Otomasyonu
{

        public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=mustafa;Integrated Security=True;");


        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                string kullaniciAdi = txtKullaniciadi.Text;
                string kullaniciSifre = txtKullanicipassword.Text;

                try
                {
                    // Bağlantıyı aç
                    baglanti.Open();

                    // SQL sorgusu
                    string sorgu = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    // Parametre ekle
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", kullaniciSifre);

                    // Kullanıcı var mı kontrol et
                    int sonuc = (int)komut.ExecuteScalar();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriş Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ana ekrana geç
                        AnaSayfa anaEkran = new AnaSayfa();
                        anaEkran.Show();
                        this.Hide(); // Giriş ekranını gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Bağlantıyı kapat
                    baglanti.Close();
                }

        }
    }
}
