namespace Banka_Test
{
    partial class Hareketleri_Goster
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
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblKimlik = new System.Windows.Forms.Label();
            this.LblHesap = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHarGos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(169, 121);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(45, 25);
            this.LblTelefon.TabIndex = 15;
            this.LblTelefon.Text = "Null";
            // 
            // LblKimlik
            // 
            this.LblKimlik.AutoSize = true;
            this.LblKimlik.Location = new System.Drawing.Point(169, 96);
            this.LblKimlik.Name = "LblKimlik";
            this.LblKimlik.Size = new System.Drawing.Size(45, 25);
            this.LblKimlik.TabIndex = 14;
            this.LblKimlik.Text = "Null";
            // 
            // LblHesap
            // 
            this.LblHesap.AutoSize = true;
            this.LblHesap.Location = new System.Drawing.Point(169, 71);
            this.LblHesap.Name = "LblHesap";
            this.LblHesap.Size = new System.Drawing.Size(45, 25);
            this.LblHesap.TabIndex = 13;
            this.LblHesap.Text = "Null";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(169, 46);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(45, 25);
            this.LblAdSoyad.TabIndex = 12;
            this.LblAdSoyad.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC Kimlik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hesap No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad:";
            // 
            // BtnHarGos
            // 
            this.BtnHarGos.Location = new System.Drawing.Point(63, 166);
            this.BtnHarGos.Name = "BtnHarGos";
            this.BtnHarGos.Size = new System.Drawing.Size(151, 58);
            this.BtnHarGos.TabIndex = 16;
            this.BtnHarGos.Text = "Hareketleri Göster";
            this.BtnHarGos.UseVisualStyleBackColor = true;
            this.BtnHarGos.Click += new System.EventHandler(this.BtnHarGos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 178);
            this.dataGridView1.TabIndex = 17;
            // 
            // Hareketleri_Goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1028, 270);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnHarGos);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblKimlik);
            this.Controls.Add(this.LblHesap);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hareketleri_Goster";
            this.Text = "Hareketleri_Goster";
            this.Load += new System.EventHandler(this.Hareketleri_Goster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblKimlik;
        private System.Windows.Forms.Label LblHesap;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHarGos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}