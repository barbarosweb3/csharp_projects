using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kelime_Ogren
{
    public partial class Kelime_Avý : Form
    {
        public Kelime_Avý()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\barba\OneDrive\Masaüstü\dbSozluk.accdb");
        Random rand = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rand.Next(1, 2490);


            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtIngilizce.Text = reader[1].ToString();
                LblCevap.Text = reader[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            TxtTurkce.Focus();
            timer1.Start();
        }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (TxtTurkce.Text == LblCevap.Text)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                getir();
                TxtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtTurkce.Enabled = false;
                TxtIngilizce.Enabled = false;
                timer1.Stop();
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanýcý_Bilgi_Sayfasý kbs = new Kullanýcý_Bilgi_Sayfasý();
            kbs.Show();
            this.Hide();
        }
    }
}
