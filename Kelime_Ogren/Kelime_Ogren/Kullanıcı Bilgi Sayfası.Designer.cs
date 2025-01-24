namespace Kelime_Ogren
{
    partial class Kullanıcı_Bilgi_Sayfası
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            TxtID = new TextBox();
            label5 = new Label();
            BtnKullaniciGuncelle = new Button();
            BtnKullaniciSil = new Button();
            BtnKullaniciEkle = new Button();
            TxtDogruSayisi = new TextBox();
            TxtKullaniciID = new TextBox();
            TxtAdSoyad = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            LblKullaniciID = new Label();
            label6 = new Label();
            LblAdSoyad = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 133);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Doğru Sayısı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnKullaniciGuncelle);
            groupBox1.Controls.Add(BtnKullaniciSil);
            groupBox1.Controls.Add(BtnKullaniciEkle);
            groupBox1.Controls.Add(TxtDogruSayisi);
            groupBox1.Controls.Add(TxtKullaniciID);
            groupBox1.Controls.Add(TxtAdSoyad);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 288);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(118, 35);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(163, 27);
            TxtID.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 38);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 9;
            label5.Text = "ID:";
            // 
            // BtnKullaniciGuncelle
            // 
            BtnKullaniciGuncelle.Location = new Point(118, 231);
            BtnKullaniciGuncelle.Name = "BtnKullaniciGuncelle";
            BtnKullaniciGuncelle.Size = new Size(163, 28);
            BtnKullaniciGuncelle.TabIndex = 8;
            BtnKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            BtnKullaniciGuncelle.UseVisualStyleBackColor = true;
            BtnKullaniciGuncelle.Click += BtnKullaniciGuncelle_Click;
            // 
            // BtnKullaniciSil
            // 
            BtnKullaniciSil.Location = new Point(118, 197);
            BtnKullaniciSil.Name = "BtnKullaniciSil";
            BtnKullaniciSil.Size = new Size(163, 28);
            BtnKullaniciSil.TabIndex = 7;
            BtnKullaniciSil.Text = "Kullanıcı Sil";
            BtnKullaniciSil.UseVisualStyleBackColor = true;
            BtnKullaniciSil.Click += BtnKullaniciSil_Click;
            // 
            // BtnKullaniciEkle
            // 
            BtnKullaniciEkle.Location = new Point(118, 163);
            BtnKullaniciEkle.Name = "BtnKullaniciEkle";
            BtnKullaniciEkle.Size = new Size(163, 28);
            BtnKullaniciEkle.TabIndex = 6;
            BtnKullaniciEkle.Text = "Kullanıcı Ekle";
            BtnKullaniciEkle.UseVisualStyleBackColor = true;
            BtnKullaniciEkle.Click += BtnKullaniciEkle_Click;
            // 
            // TxtDogruSayisi
            // 
            TxtDogruSayisi.Location = new Point(118, 130);
            TxtDogruSayisi.Name = "TxtDogruSayisi";
            TxtDogruSayisi.Size = new Size(163, 27);
            TxtDogruSayisi.TabIndex = 5;
            // 
            // TxtKullaniciID
            // 
            TxtKullaniciID.Location = new Point(118, 99);
            TxtKullaniciID.Name = "TxtKullaniciID";
            TxtKullaniciID.Size = new Size(163, 27);
            TxtKullaniciID.TabIndex = 4;
            // 
            // TxtAdSoyad
            // 
            TxtAdSoyad.Location = new Point(118, 68);
            TxtAdSoyad.Name = "TxtAdSoyad";
            TxtAdSoyad.Size = new Size(163, 27);
            TxtAdSoyad.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(LblKullaniciID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(LblAdSoyad);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 132);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(174, 98);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 8;
            label9.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 98);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 7;
            label8.Text = "Doğru Sayısı:";
            // 
            // LblKullaniciID
            // 
            LblKullaniciID.AutoSize = true;
            LblKullaniciID.Location = new Point(174, 69);
            LblKullaniciID.Name = "LblKullaniciID";
            LblKullaniciID.Size = new Size(36, 20);
            LblKullaniciID.TabIndex = 6;
            LblKullaniciID.Text = "Null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 69);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 5;
            label6.Text = "Kullanıcı Adı:";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(174, 38);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(64, 20);
            LblAdSoyad.TabIndex = 4;
            LblAdSoyad.Text = "Null null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 38);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Ad - Soyad:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 426);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Kullanıcı_Bilgi_Sayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Kullanıcı_Bilgi_Sayfası";
            Text = "Kullanıcı_Bilgi_Sayfası";
            Load += Kullanıcı_Bilgi_Sayfası_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button BtnKullaniciEkle;
        private TextBox TxtDogruSayisi;
        private TextBox TxtKullaniciID;
        private TextBox TxtAdSoyad;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label LblKullaniciID;
        private Label label6;
        private Label LblAdSoyad;
        private Label label4;
        private DataGridView dataGridView1;
        private Button BtnKullaniciGuncelle;
        private Button BtnKullaniciSil;
        private TextBox TxtID;
        private Label label5;
    }
}