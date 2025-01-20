namespace Kutuphane_Otomasyonu
{
    partial class PersonelYetkilendirmeEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArayici = new System.Windows.Forms.TextBox();
            this.BtnArayici = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboYetkidurumu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtKullaniciPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "T.C. ile ara";
            // 
            // txtArayici
            // 
            this.txtArayici.Location = new System.Drawing.Point(114, 21);
            this.txtArayici.Name = "txtArayici";
            this.txtArayici.Size = new System.Drawing.Size(121, 20);
            this.txtArayici.TabIndex = 12;
            // 
            // BtnArayici
            // 
            this.BtnArayici.Location = new System.Drawing.Point(33, 62);
            this.BtnArayici.Name = "BtnArayici";
            this.BtnArayici.Size = new System.Drawing.Size(75, 23);
            this.BtnArayici.TabIndex = 13;
            this.BtnArayici.Text = "çağır";
            this.BtnArayici.UseVisualStyleBackColor = true;
            this.BtnArayici.Click += new System.EventHandler(this.BtnArayici_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 140);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yetki Durumu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboYetkidurumu
            // 
            this.comboYetkidurumu.FormattingEnabled = true;
            this.comboYetkidurumu.Items.AddRange(new object[] {
            "Yetkili",
            "Yetkisiz"});
            this.comboYetkidurumu.Location = new System.Drawing.Point(114, 140);
            this.comboYetkidurumu.Name = "comboYetkidurumu";
            this.comboYetkidurumu.Size = new System.Drawing.Size(121, 21);
            this.comboYetkidurumu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kullanıcı adı belirleyin ";
            // 
            // txtKullaniciAdiSoyadi
            // 
            this.txtKullaniciAdiSoyadi.Location = new System.Drawing.Point(132, 195);
            this.txtKullaniciAdiSoyadi.Name = "txtKullaniciAdiSoyadi";
            this.txtKullaniciAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdiSoyadi.TabIndex = 18;
            // 
            // txtKullaniciPassword
            // 
            this.txtKullaniciPassword.Location = new System.Drawing.Point(404, 195);
            this.txtKullaniciPassword.Name = "txtKullaniciPassword";
            this.txtKullaniciPassword.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciPassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kullanıcı Şifresi belirleyin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PersonelYetkilendirmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKullaniciPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKullaniciAdiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboYetkidurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArayici);
            this.Controls.Add(this.BtnArayici);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PersonelYetkilendirmeEkrani";
            this.Text = "PersonelYetkilendirmeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArayici;
        private System.Windows.Forms.Button BtnArayici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboYetkidurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciAdiSoyadi;
        private System.Windows.Forms.TextBox txtKullaniciPassword;
        private System.Windows.Forms.Label label4;
    }
}