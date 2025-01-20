namespace Kutuphane_Otomasyonu
{
    partial class EmanetKitapIade
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
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArayici = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnArayici = new System.Windows.Forms.Button();
            this.txtIsimArayıcı = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(433, 200);
            this.dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Silme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(5, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "T.C. ile ara";
            // 
            // txtArayici
            // 
            this.txtArayici.Location = new System.Drawing.Point(86, 24);
            this.txtArayici.Name = "txtArayici";
            this.txtArayici.Size = new System.Drawing.Size(100, 20);
            this.txtArayici.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "çağır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnArayici
            // 
            this.BtnArayici.Location = new System.Drawing.Point(218, 26);
            this.BtnArayici.Name = "BtnArayici";
            this.BtnArayici.Size = new System.Drawing.Size(75, 23);
            this.BtnArayici.TabIndex = 26;
            this.BtnArayici.Text = "çağır";
            this.BtnArayici.UseVisualStyleBackColor = true;
            this.BtnArayici.Click += new System.EventHandler(this.BtnArayici_Click_1);
            // 
            // txtIsimArayıcı
            // 
            this.txtIsimArayıcı.Location = new System.Drawing.Point(86, 55);
            this.txtIsimArayıcı.Name = "txtIsimArayıcı";
            this.txtIsimArayıcı.Size = new System.Drawing.Size(100, 20);
            this.txtIsimArayıcı.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "İsim ile ara";
            // 
            // EmanetKitapIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArayici);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnArayici);
            this.Controls.Add(this.txtIsimArayıcı);
            this.Controls.Add(this.label11);
            this.Name = "EmanetKitapIade";
            this.Text = "Emanet Kitap İade";
            this.Load += new System.EventHandler(this.EmanetKitapIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtArayici;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnArayici;
        private System.Windows.Forms.TextBox txtIsimArayıcı;
        private System.Windows.Forms.Label label11;
    }
}