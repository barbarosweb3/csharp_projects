using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kelime_Ogren
{
    public partial class Kullanıcı_Bilgi_Sayfası : Form
    {
        public Kullanıcı_Bilgi_Sayfası()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\barba\OneDrive\Masaüstü\dbSozluk.accdb");

        private void ListeyiGuncelle()
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

            try
            {
                baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM kullanıcılar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri gösterme hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void Kullanıcı_Bilgi_Sayfası_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtID.Text = dataGridView1.Rows[secilen].Cells["Kimlik"].Value.ToString();
                TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells["adsoyad"].Value.ToString();
                TxtKullaniciID.Text = dataGridView1.Rows[secilen].Cells["kullanıcı_id"].Value.ToString();
                TxtDogruSayisi.Text = dataGridView1.Rows[secilen].Cells["Dogru_Sayisi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri aktarma hatası: " + ex.Message);
            }
        }

        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO kullanıcılar (adsoyad, kullanıcı_id, Dogru_Sayisi) VALUES (@p1, @p2, @p3)", baglanti);
                cmd.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@p2", TxtKullaniciID.Text);
                cmd.Parameters.AddWithValue("@p3", TxtDogruSayisi.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kullanıcı Eklendi");
                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void BtnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM kullanıcılar WHERE Kimlik = @p1", baglanti);
                cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kullanıcı Silindi");
                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void BtnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE kullanıcılar SET adsoyad = @p1, kullanıcı_id = @p2, Dogru_Sayisi = @p3 WHERE Kimlik = @p4", baglanti);
                cmd.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@p2", TxtKullaniciID.Text);
                cmd.Parameters.AddWithValue("@p3", TxtDogruSayisi.Text);
                cmd.Parameters.AddWithValue("@p4", TxtID.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kullanıcı Güncellendi");
                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Seçilen satırın index'ini al
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                // TextBox'lara verileri aktar
                TxtID.Text = dataGridView1.Rows[secilen].Cells["Kimlik"].Value.ToString();
                TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells["adsoyad"].Value.ToString();
                TxtKullaniciID.Text = dataGridView1.Rows[secilen].Cells["kullanıcı_id"].Value.ToString();
                TxtDogruSayisi.Text = dataGridView1.Rows[secilen].Cells["Dogru_Sayisi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri aktarma hatası: " + ex.Message);
            }
        }
    }
    }