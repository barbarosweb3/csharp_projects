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
using System.IO;

namespace Etut_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=EtutTest;Integrated Security=True;TrustServerCertificate=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }

        // Etüt Listesi
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute Etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();

            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbYeniOgretmenBrans.ValueMember = "DERSID";
            CmbYeniOgretmenBrans.DisplayMember = "DERSAD";
            CmbYeniOgretmenBrans.DataSource = dt;
        }

        private void BtnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüd Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLOGRETMEN where BRANSID=" + CmbDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "AD";
            CmbOgretmen.DataSource = dt2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; ;

            TxtEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update TBLETUT set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtOgrenci.Text);
            cmd.Parameters.AddWithValue("@p2", "True");
            cmd.Parameters.AddWithValue("@p3", TxtEtutID.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnYeniOgrenciFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLOGRENCI(AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtYeniOgrenciAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtYeniOgrenciSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            cmd.Parameters.AddWithValue("@p4", TxtYeniOgrenciSinif.Text);
            cmd.Parameters.AddWithValue("@p5", MskYeniOgrenciTelefon.Text);
            cmd.Parameters.AddWithValue("@p6", TxtYeniOgrenciMail.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYeniOgretmen_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLOGRETMEN(AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtYeniOgretmenAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtYeniOgretmenSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", CmbYeniOgretmenBrans.SelectedValue);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Öğretmen Eklendi");
        }

        private void BtnYeniDersEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("SELECT * FROM TBLDERSLER WHERE DERSAD=@p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", TxtYeniDersAdi.Text);
            SqlDataReader dr = kontrol.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Bu ders zaten mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
                return;
            }
            dr.Close();

            SqlCommand cmd = new SqlCommand("insert into TBLDERSLER(DERSAD) values (@p1)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtYeniDersAdi.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Ders Eklendi");
        }
    }
}
