
namespace Halisaha_Rezervasyon_v3
{
    partial class FmIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmIslemler));
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbSaha = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.rbOdendi = new System.Windows.Forms.RadioButton();
            this.rbOdenmedi = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSolOk = new System.Windows.Forms.Button();
            this.btnIptaller = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(168, 121);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(229, 20);
            this.txtMusteriAdSoyad.TabIndex = 0;
            this.txtMusteriAdSoyad.TextChanged += new System.EventHandler(this.txtMusteriAdSoyad_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(168, 169);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(229, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // cmbSaha
            // 
            this.cmbSaha.FormattingEnabled = true;
            this.cmbSaha.Items.AddRange(new object[] {
            "Saha A",
            "Saha B",
            "VIP Saha"});
            this.cmbSaha.Location = new System.Drawing.Point(168, 215);
            this.cmbSaha.Name = "cmbSaha";
            this.cmbSaha.Size = new System.Drawing.Size(229, 21);
            this.cmbSaha.TabIndex = 2;
            this.cmbSaha.SelectedIndexChanged += new System.EventHandler(this.cmbSaha_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(168, 260);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(229, 20);
            this.dtpTarih.TabIndex = 3;
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00",
            "21:00 - 22:00",
            "22:00 - 23:00",
            "23:00 - 00:00"});
            this.cmbSaat.Location = new System.Drawing.Point(168, 303);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(229, 21);
            this.cmbSaat.TabIndex = 4;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(168, 345);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(229, 20);
            this.txtUcret.TabIndex = 5;
            // 
            // rbOdendi
            // 
            this.rbOdendi.AutoSize = true;
            this.rbOdendi.Location = new System.Drawing.Point(168, 391);
            this.rbOdendi.Name = "rbOdendi";
            this.rbOdendi.Size = new System.Drawing.Size(59, 17);
            this.rbOdendi.TabIndex = 6;
            this.rbOdendi.TabStop = true;
            this.rbOdendi.Text = "Ödendi";
            this.rbOdendi.UseVisualStyleBackColor = true;
            // 
            // rbOdenmedi
            // 
            this.rbOdenmedi.AutoSize = true;
            this.rbOdenmedi.Location = new System.Drawing.Point(259, 391);
            this.rbOdenmedi.Name = "rbOdenmedi";
            this.rbOdenmedi.Size = new System.Drawing.Size(73, 17);
            this.rbOdenmedi.TabIndex = 7;
            this.rbOdenmedi.TabStop = true;
            this.rbOdenmedi.Text = "Ödenmedi";
            this.rbOdenmedi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 369);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(168, 423);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(52, 33);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(226, 423);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(64, 33);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(296, 423);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 33);
            this.btnSil.TabIndex = 11;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(344, 423);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(53, 33);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSolOk
            // 
            this.btnSolOk.Image = global::Halisaha_Rezervasyon_v3.Properties.Resources.arrows;
            this.btnSolOk.Location = new System.Drawing.Point(12, 12);
            this.btnSolOk.Name = "btnSolOk";
            this.btnSolOk.Size = new System.Drawing.Size(94, 43);
            this.btnSolOk.TabIndex = 13;
            this.btnSolOk.UseVisualStyleBackColor = true;
            this.btnSolOk.Click += new System.EventHandler(this.btnSolOk_Click);
            // 
            // btnIptaller
            // 
            this.btnIptaller.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptaller.Location = new System.Drawing.Point(12, 180);
            this.btnIptaller.Name = "btnIptaller";
            this.btnIptaller.Size = new System.Drawing.Size(122, 38);
            this.btnIptaller.TabIndex = 14;
            this.btnIptaller.Text = "İptal Edilen (Silinen) Rezervasyonlar";
            this.btnIptaller.UseVisualStyleBackColor = true;
            this.btnIptaller.Click += new System.EventHandler(this.btnIptaller_Click);
            // 
            // FmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 506);
            this.Controls.Add(this.btnIptaller);
            this.Controls.Add(this.btnSolOk);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbOdenmedi);
            this.Controls.Add(this.rbOdendi);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbSaha);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Name = "FmIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon İşlemleri Formu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbSaha;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.RadioButton rbOdendi;
        private System.Windows.Forms.RadioButton rbOdenmedi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSolOk;
        private System.Windows.Forms.Button btnIptaller;
    }
}