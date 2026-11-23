using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Halisaha_Rezervasyon_v3
{
    public partial class FmIslemler : Form
    {
        public FmIslemler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Database=halisahadb;Integrated Security=True;");

        private decimal UcretAl()
        {
            string temizUcret = txtUcret.Text.Trim().Replace(",", ".");
            return decimal.Parse(temizUcret, CultureInfo.InvariantCulture);
        }

        void Listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM rezervasyonlar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void FmIslemler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSolOk_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FmGiris)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }

        private void btnIptaller_Click(object sender, EventArgs e)
        {
            FmIptaller iptalFormu = new FmIptaller();
            iptalFormu.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "INSERT INTO rezervasyonlar (musteri_ad_soyad, telefon, saha_adi, tarih, saat, ucret, odendi_mi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)",
                    baglanti);

                komut.Parameters.AddWithValue("@p1", txtMusteriAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p3", cmbSaha.Text);
                komut.Parameters.AddWithValue("@p4", dtpTarih.Value.ToShortDateString());
                komut.Parameters.AddWithValue("@p5", cmbSaat.Text);
                komut.Parameters.AddWithValue("@p6", UcretAl());

                string odemeDurumu = rbOdendi.Checked ? "Ödendi" : "Ödenmedi";
                komut.Parameters.AddWithValue("@p7", odemeDurumu);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Rezervasyon başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();

                    baglanti.Open();
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["rezervasyon_id"].Value);

                    SqlCommand komut = new SqlCommand(
                        "UPDATE rezervasyonlar SET musteri_ad_soyad=@p1, telefon=@p2, saha_adi=@p3, tarih=@p4, saat=@p5, ucret=@p6, odendi_mi=@p7 WHERE rezervasyon_id=@p8",
                        baglanti);

                    komut.Parameters.AddWithValue("@p1", txtMusteriAdSoyad.Text);
                    komut.Parameters.AddWithValue("@p2", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@p3", cmbSaha.Text);
                    komut.Parameters.AddWithValue("@p4", dtpTarih.Value.ToShortDateString());
                    komut.Parameters.AddWithValue("@p5", cmbSaat.Text);
                    komut.Parameters.AddWithValue("@p6", UcretAl());

                    string odemeDurumu = rbOdendi.Checked ? "Ödendi" : "Ödenmedi";
                    komut.Parameters.AddWithValue("@p7", odemeDurumu);
                    komut.Parameters.AddWithValue("@p8", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Rezervasyon başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();

                    baglanti.Open();

                    DataGridViewRow satir = dataGridView1.CurrentRow;
                    int id = Convert.ToInt32(satir.Cells["rezervasyon_id"].Value);

                    SqlCommand kaydetKomut = new SqlCommand(
                        "INSERT INTO iptal_rezervasyonlar (musteri_ad_soyad, telefon, saha_adi, tarih, saat, ucret, odendi_mi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)",
                        baglanti);

                    kaydetKomut.Parameters.AddWithValue("@p1", satir.Cells["musteri_ad_soyad"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p2", satir.Cells["telefon"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p3", satir.Cells["saha_adi"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p4", satir.Cells["tarih"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p5", satir.Cells["saat"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p6", satir.Cells["ucret"].Value);
                    kaydetKomut.Parameters.AddWithValue("@p7", satir.Cells["odendi_mi"].Value);
                    kaydetKomut.ExecuteNonQuery();

                    SqlCommand silKomut = new SqlCommand("DELETE FROM rezervasyonlar WHERE rezervasyon_id=@id", baglanti);
                    silKomut.Parameters.AddWithValue("@id", id);
                    silKomut.ExecuteNonQuery();

                    baglanti.Close();

                    MessageBox.Show("Rezervasyon silindi ve iptal edilenlere kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            txtMusteriAdSoyad.Clear();
            txtTelefon.Clear();
            cmbSaha.SelectedIndex = -1;
            cmbSaat.SelectedIndex = -1;
            txtUcret.Clear();
            rbOdendi.Checked = false;
            rbOdenmedi.Checked = false;
            dtpTarih.Value = DateTime.Now;
        }

        private void cmbSaha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaha.SelectedIndex != -1)
            {
                txtUcret.Text = "3500.00";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMusteriAdSoyad.Text = row.Cells["musteri_ad_soyad"].Value != DBNull.Value ? row.Cells["musteri_ad_soyad"].Value.ToString() : "";
                txtTelefon.Text = row.Cells["telefon"].Value != DBNull.Value ? row.Cells["telefon"].Value.ToString() : "";
                cmbSaha.Text = row.Cells["saha_adi"].Value != DBNull.Value ? row.Cells["saha_adi"].Value.ToString() : "";

                if (row.Cells["tarih"].Value != DBNull.Value)
                    dtpTarih.Value = Convert.ToDateTime(row.Cells["tarih"].Value);

                cmbSaat.Text = row.Cells["saat"].Value != DBNull.Value ? row.Cells["saat"].Value.ToString() : "";
                txtUcret.Text = row.Cells["ucret"].Value != DBNull.Value ? row.Cells["ucret"].Value.ToString() : "";

                if (row.Cells["odendi_mi"].Value != DBNull.Value && row.Cells["odendi_mi"].Value.ToString() == "Ödendi")
                    rbOdendi.Checked = true;
                else
                    rbOdenmedi.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtMusteriAdSoyad_TextChanged(object sender, EventArgs e) { }
    }
}