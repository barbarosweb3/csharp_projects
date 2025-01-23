namespace Kelime_Ogren
{
    partial class Kullanıcı_Giris
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
            txtKullaniciId = new TextBox();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // txtKullaniciId
            // 
            txtKullaniciId.Location = new Point(136, 66);
            txtKullaniciId.Name = "txtKullaniciId";
            txtKullaniciId.Size = new Size(163, 27);
            txtKullaniciId.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 35);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(163, 27);
            txtAdSoyad.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 5;
            label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Kullanıcı ID:";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(136, 99);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(163, 26);
            btnGiris.TabIndex = 11;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // Kullanıcı_Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 176);
            Controls.Add(btnGiris);
            Controls.Add(txtKullaniciId);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Kullanıcı_Giris";
            Text = "Kullanıcı_Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciId;
        private TextBox txtAdSoyad;
        private Label label1;
        private Label label2;
        private Button btnGiris;
    }
}