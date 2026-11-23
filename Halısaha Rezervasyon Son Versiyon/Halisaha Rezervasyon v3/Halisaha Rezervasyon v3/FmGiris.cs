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

namespace Halisaha_Rezervasyon_v3
{
    public partial class FmGiris : Form
    {
        
        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Database=halisahadb;Integrated Security=true;");

        public FmGiris()
        {
            InitializeComponent();
        }

        private void FmGiris_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Halısaha Rezervasyon - Giriş Ekranı";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string sorgu = "SELECT * FROM kullanicilar WHERE kullanici_adi=@p1 AND sifre=@p2";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    FmIslemler anaForm = new FmIslemler();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}