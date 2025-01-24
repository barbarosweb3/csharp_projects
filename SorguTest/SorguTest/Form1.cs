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
using System.Net.NetworkInformation;

namespace SorguTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbPersonel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sorgu = richTextBox1.Text;
            try
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from TBLBİLGİ", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış veri girdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
