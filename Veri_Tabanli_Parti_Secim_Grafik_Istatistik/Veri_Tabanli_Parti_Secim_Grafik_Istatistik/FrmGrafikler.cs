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

namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbSecimProje;Integrated Security=True;TrustServerCertificate=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını Combobox'a Aktarma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlceSec.Items.Add(dr[0]);
            }
            baglanti.Close();

            // Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void CmbIlceSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", CmbIlceSec.SelectedItem.ToString());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                pbA.Value = int.Parse(dr3[2].ToString());
                lblA.Text = dr3[2].ToString();
                pbB.Value = int.Parse(dr3[3].ToString());
                lblB.Text = dr3[3].ToString();
                pbC.Value = int.Parse(dr3[4].ToString());
                lblC.Text = dr3[4].ToString();
                pbD.Value = int.Parse(dr3[5].ToString());
                lblD.Text = dr3[5].ToString();
                pbE.Value = int.Parse(dr3[6].ToString());
                lblE.Text = dr3[6].ToString();
            }
            baglanti.Close();
        }
    }
}
