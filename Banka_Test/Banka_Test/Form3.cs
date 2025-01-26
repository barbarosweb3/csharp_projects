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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbBankaTest;Integrated Security=True;TrustServerCertificate=True");

        private void BtnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLKISILER (Ad,Soyad,TC,Telefon,HesapNo,Sıfre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskID.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel.Text);
            cmd.Parameters.AddWithValue("@p5", mskHessap.Text);
            cmd.Parameters.AddWithValue("@p6", TxtSiffre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnDots_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100000, 1000000);
            mskHessap.Text = sayi.ToString();
        }
    }
}
