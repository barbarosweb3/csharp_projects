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
    public partial class Hareketleri_Goster : Form
    {
        public Hareketleri_Goster()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbBankaTest;Integrated Security=True;TrustServerCertificate=True");

        public string hesap;

        private void BtnHarGos_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from TBLHAREKET", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }

        private void Hareketleri_Goster_Load(object sender, EventArgs e)
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
    }
}
