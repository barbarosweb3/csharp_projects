namespace Banka_Test
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.mskHessap = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtSiffre = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDots = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC KİMLİK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "HESAP NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "SOYAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ŞİFRE:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(161, 54);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(170, 30);
            this.TxtAd.TabIndex = 1;
            // 
            // mskHessap
            // 
            this.mskHessap.Enabled = false;
            this.mskHessap.Location = new System.Drawing.Point(161, 162);
            this.mskHessap.Mask = "000000";
            this.mskHessap.Name = "mskHessap";
            this.mskHessap.Size = new System.Drawing.Size(170, 30);
            this.mskHessap.TabIndex = 4;
            this.mskHessap.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(161, 90);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(170, 30);
            this.TxtSoyad.TabIndex = 2;
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(161, 126);
            this.mskID.Mask = "00000000000";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(170, 30);
            this.mskID.TabIndex = 3;
            this.mskID.ValidatingType = typeof(int);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(161, 198);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(170, 30);
            this.mskTel.TabIndex = 5;
            // 
            // TxtSiffre
            // 
            this.TxtSiffre.Location = new System.Drawing.Point(161, 234);
            this.TxtSiffre.Name = "TxtSiffre";
            this.TxtSiffre.Size = new System.Drawing.Size(170, 30);
            this.TxtSiffre.TabIndex = 6;
            this.TxtSiffre.UseSystemPasswordChar = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(161, 309);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 33);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDots
            // 
            this.BtnDots.Location = new System.Drawing.Point(337, 161);
            this.BtnDots.Name = "BtnDots";
            this.BtnDots.Size = new System.Drawing.Size(37, 33);
            this.BtnDots.TabIndex = 4;
            this.BtnDots.Text = "...";
            this.BtnDots.UseVisualStyleBackColor = true;
            this.BtnDots.Click += new System.EventHandler(this.BtnDots_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "BAKIYE:";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(161, 270);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(170, 30);
            this.TxtBakiye.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(425, 447);
            this.Controls.Add(this.TxtBakiye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnDots);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtSiffre);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.mskHessap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox mskHessap;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox TxtSiffre;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDots;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBakiye;
    }
}