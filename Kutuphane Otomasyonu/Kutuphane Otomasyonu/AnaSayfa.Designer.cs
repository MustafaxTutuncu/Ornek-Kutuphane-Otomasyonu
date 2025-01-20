namespace Kutuphane_Otomasyonu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeKaydıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeBilgileriGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSilmeİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapBilgileriGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYetkilendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYetkilendirmeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYetkisizlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliPersonelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilmeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapVermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.emanetKitapİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeKaydıEklemeToolStripMenuItem,
            this.üyeListesiToolStripMenuItem});
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            // 
            // üyeKaydıEklemeToolStripMenuItem
            // 
            this.üyeKaydıEklemeToolStripMenuItem.Name = "üyeKaydıEklemeToolStripMenuItem";
            this.üyeKaydıEklemeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.üyeKaydıEklemeToolStripMenuItem.Text = "Üye Kaydı Ekleme";
            this.üyeKaydıEklemeToolStripMenuItem.Click += new System.EventHandler(this.üyeKaydıEklemeToolStripMenuItem_Click);
            // 
            // üyeListesiToolStripMenuItem
            // 
            this.üyeListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeListesiToolStripMenuItem1,
            this.üyeAramaToolStripMenuItem,
            this.üyeBilgileriGüncellemeToolStripMenuItem,
            this.üyeSilmeİşlemiToolStripMenuItem});
            this.üyeListesiToolStripMenuItem.Name = "üyeListesiToolStripMenuItem";
            this.üyeListesiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.üyeListesiToolStripMenuItem.Text = "Üye Listesi";
            // 
            // üyeListesiToolStripMenuItem1
            // 
            this.üyeListesiToolStripMenuItem1.Name = "üyeListesiToolStripMenuItem1";
            this.üyeListesiToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.üyeListesiToolStripMenuItem1.Text = "Üye Listesi";
            this.üyeListesiToolStripMenuItem1.Click += new System.EventHandler(this.üyeListesiToolStripMenuItem1_Click);
            // 
            // üyeAramaToolStripMenuItem
            // 
            this.üyeAramaToolStripMenuItem.Name = "üyeAramaToolStripMenuItem";
            this.üyeAramaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.üyeAramaToolStripMenuItem.Text = "Üye Arama";
            this.üyeAramaToolStripMenuItem.Click += new System.EventHandler(this.üyeAramaToolStripMenuItem_Click);
            // 
            // üyeBilgileriGüncellemeToolStripMenuItem
            // 
            this.üyeBilgileriGüncellemeToolStripMenuItem.Name = "üyeBilgileriGüncellemeToolStripMenuItem";
            this.üyeBilgileriGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.üyeBilgileriGüncellemeToolStripMenuItem.Text = "Üye Bilgileri Güncelleme";
            this.üyeBilgileriGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.üyeBilgileriGüncellemeToolStripMenuItem_Click);
            // 
            // üyeSilmeİşlemiToolStripMenuItem
            // 
            this.üyeSilmeİşlemiToolStripMenuItem.Name = "üyeSilmeİşlemiToolStripMenuItem";
            this.üyeSilmeİşlemiToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.üyeSilmeİşlemiToolStripMenuItem.Text = "Üye Silme İşlemi ";
            this.üyeSilmeİşlemiToolStripMenuItem.Click += new System.EventHandler(this.üyeSilmeİşlemiToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKayıtİşlemiToolStripMenuItem,
            this.kitapListesiToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapKayıtİşlemiToolStripMenuItem
            // 
            this.kitapKayıtİşlemiToolStripMenuItem.Name = "kitapKayıtİşlemiToolStripMenuItem";
            this.kitapKayıtİşlemiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapKayıtİşlemiToolStripMenuItem.Text = "Kitap Kayıt İşlemi";
            this.kitapKayıtİşlemiToolStripMenuItem.Click += new System.EventHandler(this.kitapKayıtİşlemiToolStripMenuItem_Click);
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiToolStripMenuItem1,
            this.kitapAramaToolStripMenuItem,
            this.kitapBilgileriGüncellemeToolStripMenuItem,
            this.kitapSilmeToolStripMenuItem});
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapListesiToolStripMenuItem.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem_Click);
            // 
            // kitapListesiToolStripMenuItem1
            // 
            this.kitapListesiToolStripMenuItem1.Name = "kitapListesiToolStripMenuItem1";
            this.kitapListesiToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.kitapListesiToolStripMenuItem1.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem1.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem1_Click);
            // 
            // kitapAramaToolStripMenuItem
            // 
            this.kitapAramaToolStripMenuItem.Name = "kitapAramaToolStripMenuItem";
            this.kitapAramaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kitapAramaToolStripMenuItem.Text = "Kitap Arama";
            this.kitapAramaToolStripMenuItem.Click += new System.EventHandler(this.kitapAramaToolStripMenuItem_Click);
            // 
            // kitapBilgileriGüncellemeToolStripMenuItem
            // 
            this.kitapBilgileriGüncellemeToolStripMenuItem.Name = "kitapBilgileriGüncellemeToolStripMenuItem";
            this.kitapBilgileriGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kitapBilgileriGüncellemeToolStripMenuItem.Text = "Kitap Bilgileri Güncelleme";
            this.kitapBilgileriGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.kitapBilgileriGüncellemeToolStripMenuItem_Click);
            // 
            // kitapSilmeToolStripMenuItem
            // 
            this.kitapSilmeToolStripMenuItem.Name = "kitapSilmeToolStripMenuItem";
            this.kitapSilmeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kitapSilmeToolStripMenuItem.Text = "Kitap Silme";
            this.kitapSilmeToolStripMenuItem.Click += new System.EventHandler(this.kitapSilmeToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtEkranıToolStripMenuItem,
            this.personelYetkilendirmeToolStripMenuItem,
            this.yetkiliPersonelListesiToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem1});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelKayıtEkranıToolStripMenuItem
            // 
            this.personelKayıtEkranıToolStripMenuItem.Name = "personelKayıtEkranıToolStripMenuItem";
            this.personelKayıtEkranıToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelKayıtEkranıToolStripMenuItem.Text = "Personel Kayıt Ekranı";
            // 
            // personelYetkilendirmeToolStripMenuItem
            // 
            this.personelYetkilendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelYetkilendirmeToolStripMenuItem1,
            this.personelYetkisizlendirmeToolStripMenuItem});
            this.personelYetkilendirmeToolStripMenuItem.Name = "personelYetkilendirmeToolStripMenuItem";
            this.personelYetkilendirmeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelYetkilendirmeToolStripMenuItem.Text = "Personel Yetkilendirme";
            this.personelYetkilendirmeToolStripMenuItem.Click += new System.EventHandler(this.personelYetkilendirmeToolStripMenuItem_Click);
            // 
            // personelYetkilendirmeToolStripMenuItem1
            // 
            this.personelYetkilendirmeToolStripMenuItem1.Name = "personelYetkilendirmeToolStripMenuItem1";
            this.personelYetkilendirmeToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.personelYetkilendirmeToolStripMenuItem1.Text = "Personel Yetkilendirme";
            // 
            // personelYetkisizlendirmeToolStripMenuItem
            // 
            this.personelYetkisizlendirmeToolStripMenuItem.Name = "personelYetkisizlendirmeToolStripMenuItem";
            this.personelYetkisizlendirmeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.personelYetkisizlendirmeToolStripMenuItem.Text = "Personel Yetkisizlendirme";
            // 
            // yetkiliPersonelListesiToolStripMenuItem
            // 
            this.yetkiliPersonelListesiToolStripMenuItem.Name = "yetkiliPersonelListesiToolStripMenuItem";
            this.yetkiliPersonelListesiToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.yetkiliPersonelListesiToolStripMenuItem.Text = "Yetkili Personel Listesi ";
            // 
            // personelİşlemleriToolStripMenuItem1
            // 
            this.personelİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelAramaToolStripMenuItem,
            this.personelBilgileriGüncellemeToolStripMenuItem,
            this.personelSilmeEkranıToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem1.Name = "personelİşlemleriToolStripMenuItem1";
            this.personelİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.personelİşlemleriToolStripMenuItem1.Text = "Personel İşlemleri ";
            // 
            // personelAramaToolStripMenuItem
            // 
            this.personelAramaToolStripMenuItem.Name = "personelAramaToolStripMenuItem";
            this.personelAramaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.personelAramaToolStripMenuItem.Text = "Personel Arama";
            // 
            // personelBilgileriGüncellemeToolStripMenuItem
            // 
            this.personelBilgileriGüncellemeToolStripMenuItem.Name = "personelBilgileriGüncellemeToolStripMenuItem";
            this.personelBilgileriGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.personelBilgileriGüncellemeToolStripMenuItem.Text = "Personel Bilgileri Güncelleme";
            // 
            // personelSilmeEkranıToolStripMenuItem
            // 
            this.personelSilmeEkranıToolStripMenuItem.Name = "personelSilmeEkranıToolStripMenuItem";
            this.personelSilmeEkranıToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.personelSilmeEkranıToolStripMenuItem.Text = "Personel Silme Ekranı";
            // 
            // emanetKitapİşlemleriToolStripMenuItem
            // 
            this.emanetKitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetKitapVermeToolStripMenuItem,
            this.emanetKitapİadeToolStripMenuItem});
            this.emanetKitapİşlemleriToolStripMenuItem.Name = "emanetKitapİşlemleriToolStripMenuItem";
            this.emanetKitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.emanetKitapİşlemleriToolStripMenuItem.Text = "Emanet Kitap İşlemleri ";
            // 
            // emanetKitapVermeToolStripMenuItem
            // 
            this.emanetKitapVermeToolStripMenuItem.Name = "emanetKitapVermeToolStripMenuItem";
            this.emanetKitapVermeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emanetKitapVermeToolStripMenuItem.Text = "Emanet Kitap Verme";
            // 
            // emanetKitapİadeToolStripMenuItem
            // 
            this.emanetKitapİadeToolStripMenuItem.Name = "emanetKitapİadeToolStripMenuItem";
            this.emanetKitapİadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emanetKitapİadeToolStripMenuItem.Text = "Emanet Kitap İade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeKaydıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem üyeAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeBilgileriGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeSilmeİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kitapAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapBilgileriGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelYetkilendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliPersonelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilmeEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelYetkilendirmeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelYetkisizlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitapVermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitapİadeToolStripMenuItem;
    }
}

