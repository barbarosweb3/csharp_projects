using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kelime_Ogren
{
    public partial class Kullanıcı_Giris : Form
    {
        public Kullanıcı_Giris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\barba\OneDrive\Masaüstü\dbSozluk.accdb");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtKullaniciId.Text))
            {
                MessageBox.Show("Kullanıcı adı ve ID boş bırakılamaz!");
                return;
            }

            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM kullanıcılar WHERE adsoyad = @p1 AND kullanıcı_id = @p2", baglanti);
                cmd.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@p2", txtKullaniciId.Text);

                int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                if (sonuc > 0)
                {
                    MessageBox.Show("Giriş başarılı!");

                    // Kelime Avı formunu aç
                    Kelime_Avı kelimeAvi = new Kelime_Avı();
                    this.Hide();  // Login formunu gizle
                    kelimeAvi.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya ID hatalı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
