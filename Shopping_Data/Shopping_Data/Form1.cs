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

namespace Shopping_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT HAREKETID, URUNAD, \r\n       (AD + ' ' + SOYAD) AS 'MÜŞTERİ', \r\n       (ADSOYAD) AS 'PERSONEL', \r\n       TBLURUNLER.FIYAT as 'FİYAT' \r\nFROM TBLHAREKET \r\nLEFT JOIN TBLURUNLER ON TBLHAREKET.URUN = TBLURUNLER.URUNID\r\nLEFT JOIN TBLMUSTERI ON TBLHAREKET.MUSTERI = TBLMUSTERI.ID\r\nLEFT JOIN TBLPERSONEL ON TBLHAREKET.PERSONEL = TBLPERSONEL.ID\r\n", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }


    }
}
