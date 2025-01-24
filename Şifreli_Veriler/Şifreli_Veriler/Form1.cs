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

namespace Şifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=Test;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *  from TBLVERILER", baglanti); 
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable decryptedDt = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = decryptedDt.NewRow();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i == 0) // ID column
                    {
                        newRow[i] = row[i];
                        continue;
                    }

                    string encryptedValue = row[i].ToString();
                    try
                    {
                        byte[] valueDizi = Convert.FromBase64String(encryptedValue);
                        string decryptedValue = ASCIIEncoding.ASCII.GetString(valueDizi);
                        newRow[i] = decryptedValue;
                    }
                    catch
                    {
                        newRow[i] = row[i];
                    }
                }
                decryptedDt.Rows.Add(newRow);
            }

            dataGridView1.DataSource = decryptedDt;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string ad = TxtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = TxtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = TxtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = TxtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = TxtHesap.Text;
            byte[] hesapdizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapsifre = Convert.ToBase64String(hesapdizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapsifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adcozum = TxtAd.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);

            string soyadcozum = TxtSoyad.Text;
            byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
            string soyadverisi = ASCIIEncoding.ASCII.GetString(soyadcozumdizi);

            string mailcozum = TxtMail.Text;
            byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
            string mailverisi = ASCIIEncoding.ASCII.GetString(mailcozumdizi);

            string sifrecozum = TxtSifre.Text;
            byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            string sifreverisi = ASCIIEncoding.ASCII.GetString(sifrecozumdizi);

            string hesapcozum = TxtHesap.Text;
            byte[] hesapcozumdizi = Convert.FromBase64String(hesapcozum);
            string hesapverisi = ASCIIEncoding.ASCII.GetString(hesapcozumdizi);
        }
    }
}
