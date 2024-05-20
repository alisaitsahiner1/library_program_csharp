namespace KitapKayit2
{
    partial class Form1
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resim = new System.Windows.Forms.TextBox();
            this.yayin_evi = new System.Windows.Forms.TextBox();
            this.tür = new System.Windows.Forms.TextBox();
            this.sayfa_sayisi = new System.Windows.Forms.TextBox();
            this.basim_tarihi = new System.Windows.Forms.TextBox();
            this.yazar = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.seri_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1103, 484);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 53);
            this.button5.TabIndex = 29;
            this.button5.Text = "Resim Ekle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1103, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 53);
            this.button4.TabIndex = 28;
            this.button4.Text = "Kitap Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1103, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 53);
            this.button3.TabIndex = 27;
            this.button3.Text = "Kitap Ara";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1103, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 53);
            this.button2.TabIndex = 26;
            this.button2.Text = "Kitap Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1103, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 591);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 263);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(638, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 308);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(82, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Resim";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(82, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Yayın Evi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(108, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tür";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(82, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sayfa Sayısı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(67, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Basım Tarihi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(108, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yazar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(108, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(108, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seri No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resim
            // 
            this.resim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.resim.Location = new System.Drawing.Point(241, 510);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(198, 27);
            this.resim.TabIndex = 13;
            // 
            // yayin_evi
            // 
            this.yayin_evi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yayin_evi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.yayin_evi.Location = new System.Drawing.Point(241, 466);
            this.yayin_evi.Name = "yayin_evi";
            this.yayin_evi.Size = new System.Drawing.Size(198, 27);
            this.yayin_evi.TabIndex = 12;
            // 
            // tür
            // 
            this.tür.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tür.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tür.Location = new System.Drawing.Point(241, 413);
            this.tür.Name = "tür";
            this.tür.Size = new System.Drawing.Size(198, 27);
            this.tür.TabIndex = 11;
            // 
            // sayfa_sayisi
            // 
            this.sayfa_sayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sayfa_sayisi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sayfa_sayisi.Location = new System.Drawing.Point(241, 362);
            this.sayfa_sayisi.Name = "sayfa_sayisi";
            this.sayfa_sayisi.Size = new System.Drawing.Size(198, 27);
            this.sayfa_sayisi.TabIndex = 10;
            // 
            // basim_tarihi
            // 
            this.basim_tarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.basim_tarihi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.basim_tarihi.Location = new System.Drawing.Point(241, 310);
            this.basim_tarihi.Name = "basim_tarihi";
            this.basim_tarihi.Size = new System.Drawing.Size(198, 27);
            this.basim_tarihi.TabIndex = 9;
            // 
            // yazar
            // 
            this.yazar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yazar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.yazar.Location = new System.Drawing.Point(241, 261);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(198, 27);
            this.yazar.TabIndex = 8;
            // 
            // ad
            // 
            this.ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ad.Location = new System.Drawing.Point(241, 214);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(198, 27);
            this.ad.TabIndex = 7;
            // 
            // seri_no
            // 
            this.seri_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seri_no.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.seri_no.Location = new System.Drawing.Point(241, 163);
            this.seri_no.Name = "seri_no";
            this.seri_no.Size = new System.Drawing.Size(198, 27);
            this.seri_no.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(470, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 134);
            this.label1.TabIndex = 6;
            this.label1.Text = "KİTAP KAYIT PROGRAMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 902);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.yayin_evi);
            this.Controls.Add(this.tür);
            this.Controls.Add(this.sayfa_sayisi);
            this.Controls.Add(this.basim_tarihi);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.seri_no);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox resim;
        private TextBox yayin_evi;
        private TextBox tür;
        private TextBox sayfa_sayisi;
        private TextBox basim_tarihi;
        private TextBox yazar;
        private TextBox ad;
        private TextBox seri_no;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}