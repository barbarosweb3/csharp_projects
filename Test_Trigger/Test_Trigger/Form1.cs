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

namespace Test_Trigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=Trigger_Test;Integrated Security=True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKITAPLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLSAYAC", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblKitap.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtYazar.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSayfa.Text);
            cmd.Parameters.AddWithValue("@p4", TxtYayinevi.Text);
            cmd.Parameters.AddWithValue("@p5", TxtTur.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYayinevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from TBLKITAPLAR where ID=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtID.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            sayac();
        }
    }
}
