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
using MongoDB.Driver;
using MongoDB.Bson;

namespace Rehber
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = Odeux\\MSSQLSERVER01; Initial Catalog = Rehber; Integrated Security = True; TrustServerCertificate=True");
        MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase mongoDatabase;

        public Form1()
        {
            InitializeComponent();
            mongoDatabase = mongoClient.GetDatabase("Rehber");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SQL Data Retrieval
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM KISILER", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void RefreshDataGridView()
        {
            try
            {
                var collection = mongoDatabase.GetCollection<BsonDocument>("KISILER");
                var records = collection.Find(new BsonDocument()).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("AD");
                dt.Columns.Add("SOYAD");
                dt.Columns.Add("TELEFON");
                dt.Columns.Add("MAIL");

                foreach (var doc in records)
                {
                    dt.Rows.Add(
                        doc["AD"].AsString,
                        doc["SOYAD"].AsString,
                        doc["TELEFON"].AsString,
                        doc["MAIL"].AsString
                    );
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listeleme hatası: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<BsonDocument>("KISILER");

                // Create a new document without replacing existing ones
                var document = new BsonDocument
        {
            { "AD", TxtAd.Text },
            { "SOYAD", TxtSoyad.Text },
            { "TELEFON", MskTelefon.Text },
            { "MAIL", TxtMail.Text }
        };

                collection.InsertOne(document);
                RefreshDataGridView();

                MessageBox.Show("Kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ekleme hatası: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<BsonDocument>("KISILER");

                // Find the document by AD, SOYAD, or another unique identifier
                var filter = Builders<BsonDocument>.Filter.Eq("AD", TxtAd.Text);

                var result = collection.DeleteOne(filter);

                // Refresh DataGridView after deletion
                RefreshDataGridView();

                MessageBox.Show($"Bilgiler Silindi. Silinen kayıt sayısı: {result.DeletedCount}",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işleminde hata: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<BsonDocument>("KISILER");

                // Filter by AD and SOYAD to identify the record
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("AD", TxtAd.Text),
                    Builders<BsonDocument>.Filter.Eq("SOYAD", TxtSoyad.Text)
                );

                // Update document
                var update = Builders<BsonDocument>.Update
                    .Set("TELEFON", MskTelefon.Text)
                    .Set("MAIL", TxtMail.Text);

                var result = collection.UpdateOne(filter, update);

                // Refresh DataGridView
                RefreshDataGridView();

                MessageBox.Show($"Bilgiler Güncellendi. Güncellenen kayıt sayısı: {result.ModifiedCount}",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme işleminde hata: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                TxtAd.Text = row.Cells["AD"].Value.ToString();
                TxtSoyad.Text = row.Cells["SOYAD"].Value.ToString();
                MskTelefon.Text = row.Cells["TELEFON"].Value.ToString();
                TxtMail.Text = row.Cells["MAIL"].Value.ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            TxtAd.Clear();
            TxtSoyad.Clear();
            MskTelefon.Clear();
            TxtMail.Clear();

            // Optional: Clear selection in DataGridView
            dataGridView1.ClearSelection();
        }
    }
}