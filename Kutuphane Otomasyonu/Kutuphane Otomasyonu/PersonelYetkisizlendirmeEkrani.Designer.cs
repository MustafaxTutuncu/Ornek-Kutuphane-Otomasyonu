using System;

namespace Kutuphane_Otomasyonu
{
    partial class PersonelYetkisizlendirmeEkrani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.BtnArayici = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 140);
            this.dataGridView1.TabIndex = 26;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(125, 12);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(121, 20);
            this.txtTc.TabIndex = 24;
            // 
            // BtnArayici
            // 
            this.BtnArayici.Location = new System.Drawing.Point(33, 56);
            this.BtnArayici.Name = "BtnArayici";
            this.BtnArayici.Size = new System.Drawing.Size(75, 23);
            this.BtnArayici.TabIndex = 25;
            this.BtnArayici.Text = "çağır";
            this.BtnArayici.UseVisualStyleBackColor = true;
            this.BtnArayici.Click += new System.EventHandler(this.BtnArayici_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Yetkiyi Kaldır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "TC ile ara ";
            // 
            // PersonelYetkisizlendirmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.BtnArayici);
            this.Controls.Add(this.button2);
            this.Name = "PersonelYetkisizlendirmeEkrani";
            this.Text = "PersonelYetkisizlendirmeEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button BtnArayici;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}