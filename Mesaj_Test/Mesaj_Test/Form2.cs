using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Mesaj_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbConnection;Integrated Security=True;TrustServerCertificate=True");
        public string numara;
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter(@"
                SELECT m.MESAJID, k1.AD + ' ' + k1.SOYAD as Gönderen, 
                    k2.AD + ' ' + k2.SOYAD as Alıcı, 
                    m.BAŞLIK, m.İÇERİK
                FROM TBLMESAJLAR m
                INNER JOIN TBLKISILER k1 ON m.GONDERICI = k1.NUMARA
                INNER JOIN TBLKISILER k2 ON m.ALICI = k2.NUMARA
                WHERE m.ALICI = " + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter(@"
               SELECT m.MESAJID, k1.AD + ' ' + k1.SOYAD as Gönderen, 
                    k2.AD + ' ' + k2.SOYAD as Alıcı, 
                    m.BAŞLIK, m.İÇERİK
               FROM TBLMESAJLAR m
              INNER JOIN TBLKISILER k1 ON m.GONDERICI = k1.NUMARA
              INNER JOIN TBLKISILER k2 ON m.ALICI = k2.NUMARA
             WHERE m.GONDERICI = " + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();
            // Ad Soyad'ı Çekme
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select AD,SOYAD from TBLKISILER where numara=" + numara, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblAdSoyad.Text = reader[0] + " " + reader[1];
            }
            baglanti.Close();
        }
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("insert into TBLMESAJLAR (GONDERICI,ALICI,BAŞLIK,İÇERİK) values (@p1,@p2,@p3,@p4)", baglanti);
            cmd2.Parameters.AddWithValue("@p1", numara);
            cmd2.Parameters.AddWithValue("@p2", MskAlici.Text);
            cmd2.Parameters.AddWithValue("@p3", TxtMesajBasligi.Text);
            cmd2.Parameters.AddWithValue("@p4", RtbMesaj.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            gidenkutusu();
        }
    }
}