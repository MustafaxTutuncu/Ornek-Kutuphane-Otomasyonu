using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JHQDRA2;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");

        private void button5_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme kitapVerme = new EmanetKitapVerme();
            kitapVerme.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmanetKitapIade kitapIade = new EmanetKitapIade();
            kitapIade.ShowDialog();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            EmanetKitapListele emakitapListe = new EmanetKitapListele();
            emakitapListe.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personelYetkilendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void üyeKaydıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.ShowDialog();
        }

        private void üyeListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UyeListele listele = new UyeListele();
            listele.ShowDialog();
        }

        private void üyeAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeArama arama = new UyeArama();
            arama.ShowDialog();
        }

        private void üyeBilgileriGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeBilgileriGuncelleme guncel = new UyeBilgileriGuncelleme();
            guncel.ShowDialog();
        }

        private void üyeSilmeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSilmeIslemi uyeSilme = new UyeSilmeIslemi();
            uyeSilme.ShowDialog();
        }

        private void kitapKayıtİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KitapListele kitapListele = new KitapListele();
            kitapListele.ShowDialog();
        }

        private void kitapAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapArama kitapArama = new KitapArama();
            kitapArama.ShowDialog();
        }

        private void kitapBilgileriGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapBilgilerininGuncellenmesi guncelle = new KitapBilgilerininGuncellenmesi();
            guncelle.ShowDialog();
        }

        private void kitapSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapKaydıSilme kitapSilme = new KitapKaydıSilme();
            kitapSilme.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string url = "https://bozok.edu.tr/okul/yozgat-myo";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch { }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string filePath = @"C:\Users\User\Desktop\KİSMİ\Kutuphane Otomasyonu\sunum\musti.docx";

            try
            {
                
                System.Diagnostics.Process.Start(filePath);
            }
            catch {}
        }

        private void personelKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayitEkrani kayit = new PersonelKayitEkrani();
            kayit.ShowDialog();
        }

        private void personelYetkilendirmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelYetkilendirmeEkrani yetkilendirme = new PersonelYetkilendirmeEkrani();
            yetkilendirme.ShowDialog();
        }

        private void personelYetkisizlendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelYetkisizlendirmeEkrani yetkisizlendirme = new PersonelYetkisizlendirmeEkrani();
            yetkisizlendirme.ShowDialog();
        }

        private void yetkiliPersonelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliPersonelListesi yetkiliPersonel = new YetkiliPersonelListesi();
            yetkiliPersonel.ShowDialog();
        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelAramaEkrani personelAra = new PersonelAramaEkrani();
            personelAra.ShowDialog();
        }

        private void personelBilgileriGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelBilgileriGuncellemeEkrani personelGuncel = new PersonelBilgileriGuncellemeEkrani(); 
            personelGuncel.ShowDialog();
        }

       
        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesi personel = new PersonelListesi();
            personel.ShowDialog();
        }

        private void emanetKitapVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme kitapveryo = new EmanetKitapVerme();
            kitapveryo.ShowDialog();
        }

        private void emanetKitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetKitapListele emanliste = new EmanetKitapListele();
            emanliste.ShowDialog();
        }

        private void emanetKitapİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetKitapIade iadeciemanet = new EmanetKitapIade();
            iadeciemanet.ShowDialog();
        }
    }
}
