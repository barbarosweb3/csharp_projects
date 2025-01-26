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

namespace Banka_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbBankaTest;Integrated Security=True;TrustServerCertificate=True");

        public string hesap;

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesap.Text = hesap;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBLKISILER where HESAPNO=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblKimlik.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // Gönderilen hesabın para artışı
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP set bakıye = bakıye + @p1 where hesapno=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));
            cmd.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();


            // Gönderen hesabın para azalışı
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("UPDATE TBLHESAP set bakıye = bakıye - @k1 where hesapno=@k2", baglanti);
            cmd2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
            cmd2.Parameters.AddWithValue("@k2", hesap);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleşti");

            // Hareket Tablosu
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("insert into TBLHAREKET (GONDEREN, ALICI, TUTAR) values (@c1,@c2,@c3)", baglanti);
            cmd3.Parameters.AddWithValue("@c1", LblHesap.Text);
            cmd3.Parameters.AddWithValue("@c2", mskHesapNo.Text);
            cmd3.Parameters.AddWithValue("@c3", TxtTutar.Text);
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gerekli Bilgiler Hareketler Tablosuna Aktarıldı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hareketleri_Goster hg = new Hareketleri_Goster();
            hg.hesap = hesap;
            hg.Show();
            this.Hide();
        }
    }
}
