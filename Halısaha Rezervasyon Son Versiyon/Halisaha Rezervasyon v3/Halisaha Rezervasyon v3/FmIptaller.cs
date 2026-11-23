using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Halisaha_Rezervasyon_v3
{
    public partial class FmIptaller : Form
    {
        public FmIptaller()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Database=halisahadb;Integrated Security=True;");

        void IptalleriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM iptal_rezervasyonlar", baglanti);
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

        private void FmIptaller_Load(object sender, EventArgs e)
        {
            IptalleriListele();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FmIslemler)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}