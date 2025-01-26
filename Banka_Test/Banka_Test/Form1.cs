using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=DbBankaTest;Integrated Security=True;TrustServerCertificate=True");

        private void lnkUyeDegilim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@P2", baglanti);
                cmd.Parameters.AddWithValue("@p1", mskHesap.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Form2 frm = new Form2();
                    frm.hesap = mskHesap.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı hesap no veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
