namespace Kelime_Ogren
{
    partial class Kelime_Avı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtIngilizce = new TextBox();
            TxtTurkce = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LblSure = new Label();
            label5 = new Label();
            LblKelime = new Label();
            LblCevap = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnKullaniciEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(92, 24);
            label1.TabIndex = 0;
            label1.Text = "İngilizce:";
            // 
            // TxtIngilizce
            // 
            TxtIngilizce.Location = new Point(134, 58);
            TxtIngilizce.Name = "TxtIngilizce";
            TxtIngilizce.Size = new Size(224, 30);
            TxtIngilizce.TabIndex = 10;
            // 
            // TxtTurkce
            // 
            TxtTurkce.Location = new Point(134, 98);
            TxtTurkce.Name = "TxtTurkce";
            TxtTurkce.Size = new Size(224, 30);
            TxtTurkce.TabIndex = 1;
            TxtTurkce.TextChanged += TxtTurkce_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 2;
            label2.Text = "Türkçe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 61);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 4;
            label3.Text = "Süre:";
            // 
            // LblSure
            // 
            LblSure.AutoSize = true;
            LblSure.Location = new Point(543, 61);
            LblSure.Name = "LblSure";
            LblSure.Size = new Size(33, 24);
            LblSure.TabIndex = 5;
            LblSure.Text = "90";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 98);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 6;
            label5.Text = "Kelime:";
            // 
            // LblKelime
            // 
            LblKelime.AutoSize = true;
            LblKelime.Location = new Point(543, 98);
            LblKelime.Name = "LblKelime";
            LblKelime.Size = new Size(22, 24);
            LblKelime.TabIndex = 7;
            LblKelime.Text = "0";
            // 
            // LblCevap
            // 
            LblCevap.AutoSize = true;
            LblCevap.Location = new Point(480, 152);
            LblCevap.Name = "LblCevap";
            LblCevap.Size = new Size(64, 24);
            LblCevap.TabIndex = 8;
            LblCevap.Text = "label4";
            LblCevap.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(134, 147);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(224, 29);
            btnKullaniciEkle.TabIndex = 11;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 224);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(LblCevap);
            Controls.Add(LblKelime);
            Controls.Add(label5);
            Controls.Add(LblSure);
            Controls.Add(label3);
            Controls.Add(TxtTurkce);
            Controls.Add(label2);
            Controls.Add(TxtIngilizce);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtIngilizce;
        private TextBox TxtTurkce;
        private Label label2;
        private Label label3;
        private Label LblSure;
        private Label label5;
        private Label LblKelime;
        private Label LblCevap;
        private System.Windows.Forms.Timer timer1;
        private Button btnKullaniciEkle;
    }
}
