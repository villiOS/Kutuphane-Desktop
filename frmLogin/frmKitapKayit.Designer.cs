namespace frmLogin
{
    partial class frmKitapKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpicYayinYili = new System.Windows.Forms.DateTimePicker();
            this.btnKitapKayitIptal = new System.Windows.Forms.Button();
            this.txtAnahtarKelimeler = new System.Windows.Forms.TextBox();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapKodu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayın Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Anahtar Kelimeler:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpicYayinYili);
            this.groupBox1.Controls.Add(this.btnKitapKayitIptal);
            this.groupBox1.Controls.Add(this.txtAnahtarKelimeler);
            this.groupBox1.Controls.Add(this.btnKitapKaydet);
            this.groupBox1.Controls.Add(this.txtSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtYazari);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.txtKitapKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 352);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt";
            // 
            // dpicYayinYili
            // 
            this.dpicYayinYili.CustomFormat = "dd-MM-yyyy";
            this.dpicYayinYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicYayinYili.Location = new System.Drawing.Point(143, 105);
            this.dpicYayinYili.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dpicYayinYili.Name = "dpicYayinYili";
            this.dpicYayinYili.Size = new System.Drawing.Size(192, 20);
            this.dpicYayinYili.TabIndex = 3;
            // 
            // btnKitapKayitIptal
            // 
            this.btnKitapKayitIptal.Location = new System.Drawing.Point(248, 316);
            this.btnKitapKayitIptal.Name = "btnKitapKayitIptal";
            this.btnKitapKayitIptal.Size = new System.Drawing.Size(87, 23);
            this.btnKitapKayitIptal.TabIndex = 9;
            this.btnKitapKayitIptal.Text = "İptal";
            this.btnKitapKayitIptal.UseVisualStyleBackColor = true;
            this.btnKitapKayitIptal.Click += new System.EventHandler(this.btnKitapKayitIptal_Click);
            // 
            // txtAnahtarKelimeler
            // 
            this.txtAnahtarKelimeler.Location = new System.Drawing.Point(143, 210);
            this.txtAnahtarKelimeler.Multiline = true;
            this.txtAnahtarKelimeler.Name = "txtAnahtarKelimeler";
            this.txtAnahtarKelimeler.Size = new System.Drawing.Size(192, 100);
            this.txtAnahtarKelimeler.TabIndex = 7;
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(143, 316);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(87, 23);
            this.btnKitapKaydet.TabIndex = 8;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            this.btnKitapKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(143, 183);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(192, 20);
            this.txtSayfaSayisi.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(143, 157);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(192, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(143, 131);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(192, 20);
            this.txtYazari.TabIndex = 4;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(143, 79);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(192, 20);
            this.txtKategori.TabIndex = 2;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(143, 53);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(192, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Location = new System.Drawing.Point(143, 27);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(192, 20);
            this.txtKitapKodu.TabIndex = 0;
            // 
            // frmKitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 363);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAnahtarKelimeler;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapKodu;
        private System.Windows.Forms.Button btnKitapKayitIptal;
        private System.Windows.Forms.DateTimePicker dpicYayinYili;
    }
}