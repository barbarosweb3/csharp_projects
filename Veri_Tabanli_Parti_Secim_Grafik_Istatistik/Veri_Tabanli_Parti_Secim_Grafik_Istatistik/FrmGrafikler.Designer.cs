namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbIlceSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbA = new System.Windows.Forms.ProgressBar();
            this.pbB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pbC = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pbD = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pbE = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Partiler";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(871, 304);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblE);
            this.groupBox2.Controls.Add(this.lblD);
            this.groupBox2.Controls.Add(this.lblC);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.lblA);
            this.groupBox2.Controls.Add(this.pbE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pbD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbIlceSec);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // CmbIlceSec
            // 
            this.CmbIlceSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIlceSec.FormattingEnabled = true;
            this.CmbIlceSec.Location = new System.Drawing.Point(200, 44);
            this.CmbIlceSec.Name = "CmbIlceSec";
            this.CmbIlceSec.Size = new System.Drawing.Size(219, 29);
            this.CmbIlceSec.TabIndex = 1;
            this.CmbIlceSec.SelectedIndexChanged += new System.EventHandler(this.CmbIlceSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİSİ:";
            // 
            // pbA
            // 
            this.pbA.Location = new System.Drawing.Point(200, 98);
            this.pbA.Maximum = 200;
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(422, 23);
            this.pbA.TabIndex = 3;
            // 
            // pbB
            // 
            this.pbB.Location = new System.Drawing.Point(200, 132);
            this.pbB.Maximum = 200;
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(422, 23);
            this.pbB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİSİ:";
            // 
            // pbC
            // 
            this.pbC.Location = new System.Drawing.Point(200, 166);
            this.pbC.Maximum = 200;
            this.pbC.Name = "pbC";
            this.pbC.Size = new System.Drawing.Size(422, 23);
            this.pbC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİSİ:";
            // 
            // pbD
            // 
            this.pbD.Location = new System.Drawing.Point(200, 200);
            this.pbD.Maximum = 200;
            this.pbD.Name = "pbD";
            this.pbD.Size = new System.Drawing.Size(422, 23);
            this.pbD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİSİ:";
            // 
            // pbE
            // 
            this.pbE.Location = new System.Drawing.Point(200, 233);
            this.pbE.Maximum = 200;
            this.pbE.Name = "pbE";
            this.pbE.Size = new System.Drawing.Size(422, 23);
            this.pbE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİSİ:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(659, 100);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 21);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(659, 134);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 21);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "0";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(659, 168);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 21);
            this.lblC.TabIndex = 14;
            this.lblC.Text = "0";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(659, 202);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(21, 21);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "0";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(659, 235);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(21, 21);
            this.lblE.TabIndex = 16;
            this.lblE.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(903, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox CmbIlceSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
    }
}