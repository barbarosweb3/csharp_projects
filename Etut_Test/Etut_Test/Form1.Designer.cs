namespace Etut_Test
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtOgrenci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEtutID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnYeniDersEkle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.BtnYeniOgrenciFoto = new System.Windows.Forms.Button();
            this.TxtYeniDersAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtYeniOgrenciAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtYeniOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYeniOgrenciSinif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtYeniOgrenciMail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MskYeniOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtYeniOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtYeniOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnYeniOgretmen = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CmbYeniOgretmenBrans = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt";
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.Location = new System.Drawing.Point(127, 192);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(258, 33);
            this.BtnEtutOlustur.TabIndex = 9;
            this.BtnEtutOlustur.Text = "Etüt Oluştur";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(127, 82);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(258, 32);
            this.CmbOgretmen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(127, 156);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(258, 30);
            this.MskSaat.TabIndex = 6;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(127, 120);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(258, 30);
            this.MskTarih.TabIndex = 4;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(127, 46);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(258, 32);
            this.CmbDers.TabIndex = 2;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtOgrenci);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(485, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etüt Al";
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.BackColor = System.Drawing.Color.Aqua;
            this.BtnEtutVer.Location = new System.Drawing.Point(170, 115);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(206, 34);
            this.BtnEtutVer.TabIndex = 5;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = false;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 353);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.Location = new System.Drawing.Point(170, 79);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(206, 30);
            this.TxtOgrenci.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Etüt ID:";
            // 
            // TxtEtutID
            // 
            this.TxtEtutID.Enabled = false;
            this.TxtEtutID.Location = new System.Drawing.Point(170, 43);
            this.TxtEtutID.Name = "TxtEtutID";
            this.TxtEtutID.Size = new System.Drawing.Size(206, 30);
            this.TxtEtutID.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtYeniDersAdi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.BtnYeniDersEkle);
            this.groupBox4.Location = new System.Drawing.Point(487, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 72);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders Ekleme";
            // 
            // BtnYeniDersEkle
            // 
            this.BtnYeniDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnYeniDersEkle.Location = new System.Drawing.Point(315, 29);
            this.BtnYeniDersEkle.Name = "BtnYeniDersEkle";
            this.BtnYeniDersEkle.Size = new System.Drawing.Size(129, 34);
            this.BtnYeniDersEkle.TabIndex = 7;
            this.BtnYeniDersEkle.Text = "Ders Ekle";
            this.BtnYeniDersEkle.UseVisualStyleBackColor = false;
            this.BtnYeniDersEkle.Click += new System.EventHandler(this.BtnYeniDersEkle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MskYeniOgrenciTelefon);
            this.groupBox5.Controls.Add(this.TxtYeniOgrenciMail);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.TxtYeniOgrenciSinif);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtYeniOgrenciAd);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtYeniOgrenciSoyad);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox5.Location = new System.Drawing.Point(959, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(321, 252);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yeni Öğrenci";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.BtnYeniOgrenciFoto);
            this.groupBox6.Location = new System.Drawing.Point(1302, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 252);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Öğrenci Fotoğraf";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CmbYeniOgretmenBrans);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.BtnYeniOgretmen);
            this.groupBox7.Controls.Add(this.TxtYeniOgretmenAd);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.TxtYeniOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(1302, 297);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(345, 340);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Yeni Öğretmen";
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(87, 209);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(206, 34);
            this.BtnOgrenciEkle.TabIndex = 8;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = false;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // BtnYeniOgrenciFoto
            // 
            this.BtnYeniOgrenciFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnYeniOgrenciFoto.Location = new System.Drawing.Point(108, 209);
            this.BtnYeniOgrenciFoto.Name = "BtnYeniOgrenciFoto";
            this.BtnYeniOgrenciFoto.Size = new System.Drawing.Size(136, 34);
            this.BtnYeniOgrenciFoto.TabIndex = 8;
            this.BtnYeniOgrenciFoto.Text = "Fotoğraf Ekle";
            this.BtnYeniOgrenciFoto.UseVisualStyleBackColor = false;
            this.BtnYeniOgrenciFoto.Click += new System.EventHandler(this.BtnYeniOgrenciFoto_Click);
            // 
            // TxtYeniDersAdi
            // 
            this.TxtYeniDersAdi.Location = new System.Drawing.Point(103, 31);
            this.TxtYeniDersAdi.Name = "TxtYeniDersAdi";
            this.TxtYeniDersAdi.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniDersAdi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ders Adı:";
            // 
            // TxtYeniOgrenciAd
            // 
            this.TxtYeniOgrenciAd.Location = new System.Drawing.Point(87, 23);
            this.TxtYeniOgrenciAd.Name = "TxtYeniOgrenciAd";
            this.TxtYeniOgrenciAd.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgrenciAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad:";
            // 
            // TxtYeniOgrenciSoyad
            // 
            this.TxtYeniOgrenciSoyad.Location = new System.Drawing.Point(87, 59);
            this.TxtYeniOgrenciSoyad.Name = "TxtYeniOgrenciSoyad";
            this.TxtYeniOgrenciSoyad.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgrenciSoyad.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Soyad:";
            // 
            // TxtYeniOgrenciSinif
            // 
            this.TxtYeniOgrenciSinif.Location = new System.Drawing.Point(87, 94);
            this.TxtYeniOgrenciSinif.Name = "TxtYeniOgrenciSinif";
            this.TxtYeniOgrenciSinif.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgrenciSinif.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sınıf:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Telefon:";
            // 
            // TxtYeniOgrenciMail
            // 
            this.TxtYeniOgrenciMail.Location = new System.Drawing.Point(87, 166);
            this.TxtYeniOgrenciMail.Name = "TxtYeniOgrenciMail";
            this.TxtYeniOgrenciMail.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgrenciMail.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Mail:";
            // 
            // MskYeniOgrenciTelefon
            // 
            this.MskYeniOgrenciTelefon.Location = new System.Drawing.Point(87, 130);
            this.MskYeniOgrenciTelefon.Mask = "(999) 000-0000";
            this.MskYeniOgrenciTelefon.Name = "MskYeniOgrenciTelefon";
            this.MskYeniOgrenciTelefon.Size = new System.Drawing.Size(206, 30);
            this.MskYeniOgrenciTelefon.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TxtYeniOgretmenAd
            // 
            this.TxtYeniOgretmenAd.Location = new System.Drawing.Point(102, 102);
            this.TxtYeniOgretmenAd.Name = "TxtYeniOgretmenAd";
            this.TxtYeniOgretmenAd.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgretmenAd.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(56, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 24);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ad:";
            // 
            // TxtYeniOgretmenSoyad
            // 
            this.TxtYeniOgretmenSoyad.Location = new System.Drawing.Point(102, 138);
            this.TxtYeniOgretmenSoyad.Name = "TxtYeniOgretmenSoyad";
            this.TxtYeniOgretmenSoyad.Size = new System.Drawing.Size(206, 30);
            this.TxtYeniOgretmenSoyad.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(32, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Soyad:";
            // 
            // BtnYeniOgretmen
            // 
            this.BtnYeniOgretmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnYeniOgretmen.Location = new System.Drawing.Point(102, 218);
            this.BtnYeniOgretmen.Name = "BtnYeniOgretmen";
            this.BtnYeniOgretmen.Size = new System.Drawing.Size(206, 34);
            this.BtnYeniOgretmen.TabIndex = 21;
            this.BtnYeniOgretmen.Text = "Öğretmen Ekle";
            this.BtnYeniOgretmen.UseVisualStyleBackColor = false;
            this.BtnYeniOgretmen.Click += new System.EventHandler(this.BtnYeniOgretmen_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(42, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ders:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CmbYeniOgretmenBrans
            // 
            this.CmbYeniOgretmenBrans.FormattingEnabled = true;
            this.CmbYeniOgretmenBrans.Location = new System.Drawing.Point(102, 174);
            this.CmbYeniOgretmenBrans.Name = "CmbYeniOgretmenBrans";
            this.CmbYeniOgretmenBrans.Size = new System.Drawing.Size(206, 32);
            this.CmbYeniOgretmenBrans.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1663, 655);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtOgrenci;
        private System.Windows.Forms.TextBox TxtEtutID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnYeniDersEkle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox TxtYeniDersAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.Button BtnYeniOgrenciFoto;
        private System.Windows.Forms.TextBox TxtYeniOgrenciMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtYeniOgrenciSinif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtYeniOgrenciAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtYeniOgrenciSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MskYeniOgrenciTelefon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnYeniOgretmen;
        private System.Windows.Forms.TextBox TxtYeniOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtYeniOgretmenSoyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CmbYeniOgretmenBrans;
    }
}

