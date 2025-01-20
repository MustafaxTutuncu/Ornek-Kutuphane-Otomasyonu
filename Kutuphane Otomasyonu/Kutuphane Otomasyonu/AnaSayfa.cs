using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

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
    }
}
