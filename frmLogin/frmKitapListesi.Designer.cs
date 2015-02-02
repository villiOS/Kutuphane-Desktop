namespace frmLogin
{
    partial class frmKitapListesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgridKitapListesi = new System.Windows.Forms.DataGridView();
            this.btnKitapListesiKapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.gboxBasitArama = new System.Windows.Forms.GroupBox();
            this.cxboxGelismisArama = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxGelismisArama = new System.Windows.Forms.GroupBox();
            this.cxboxBasitArama = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtISBNNo = new System.Windows.Forms.TextBox();
            this.txtYayinYili = new System.Windows.Forms.TextBox();
            this.txtKitapKodu = new System.Windows.Forms.TextBox();
            this.txtKitapKategori = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgridBulunanKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitapListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gboxBasitArama.SuspendLayout();
            this.gboxGelismisArama.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBulunanKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridKitapListesi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 725);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplar";
            // 
            // dgridKitapListesi
            // 
            this.dgridKitapListesi.AllowUserToOrderColumns = true;
            this.dgridKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKitapListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridKitapListesi.Location = new System.Drawing.Point(3, 16);
            this.dgridKitapListesi.Name = "dgridKitapListesi";
            this.dgridKitapListesi.Size = new System.Drawing.Size(741, 706);
            this.dgridKitapListesi.TabIndex = 0;
            this.dgridKitapListesi.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridKitapListesi_RowHeaderMouseDoubleClick);
            // 
            // btnKitapListesiKapat
            // 
            this.btnKitapListesiKapat.Location = new System.Drawing.Point(516, 704);
            this.btnKitapListesiKapat.Name = "btnKitapListesiKapat";
            this.btnKitapListesiKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKitapListesiKapat.TabIndex = 1;
            this.btnKitapListesiKapat.Text = "Kapat";
            this.btnKitapListesiKapat.UseVisualStyleBackColor = true;
            this.btnKitapListesiKapat.Click += new System.EventHandler(this.btnKitapListesiKapat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnKitapListesiKapat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(503, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 725);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapAra);
            this.groupBox3.Controls.Add(this.gboxBasitArama);
            this.groupBox3.Controls.Add(this.gboxGelismisArama);
            this.groupBox3.Location = new System.Drawing.Point(6, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 311);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Ara";
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Location = new System.Drawing.Point(23, 163);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(265, 123);
            this.btnKitapAra.TabIndex = 3;
            this.btnKitapAra.Text = "Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // gboxBasitArama
            // 
            this.gboxBasitArama.Controls.Add(this.cxboxGelismisArama);
            this.gboxBasitArama.Controls.Add(this.label2);
            this.gboxBasitArama.Controls.Add(this.txtYazar);
            this.gboxBasitArama.Controls.Add(this.txtAd);
            this.gboxBasitArama.Controls.Add(this.label1);
            this.gboxBasitArama.Location = new System.Drawing.Point(23, 29);
            this.gboxBasitArama.Name = "gboxBasitArama";
            this.gboxBasitArama.Size = new System.Drawing.Size(265, 128);
            this.gboxBasitArama.TabIndex = 2;
            this.gboxBasitArama.TabStop = false;
            this.gboxBasitArama.Text = "Basit Arama";
            // 
            // cxboxGelismisArama
            // 
            this.cxboxGelismisArama.AutoSize = true;
            this.cxboxGelismisArama.Location = new System.Drawing.Point(116, 95);
            this.cxboxGelismisArama.Name = "cxboxGelismisArama";
            this.cxboxGelismisArama.Size = new System.Drawing.Size(97, 17);
            this.cxboxGelismisArama.TabIndex = 2;
            this.cxboxGelismisArama.Text = "Gelişmiş Arama";
            this.cxboxGelismisArama.UseVisualStyleBackColor = true;
            this.cxboxGelismisArama.CheckedChanged += new System.EventHandler(this.cxboxGelismisArama_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(116, 69);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(133, 20);
            this.txtYazar.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // gboxGelismisArama
            // 
            this.gboxGelismisArama.Controls.Add(this.cxboxBasitArama);
            this.gboxGelismisArama.Controls.Add(this.label9);
            this.gboxGelismisArama.Controls.Add(this.label8);
            this.gboxGelismisArama.Controls.Add(this.label7);
            this.gboxGelismisArama.Controls.Add(this.label6);
            this.gboxGelismisArama.Controls.Add(this.label5);
            this.gboxGelismisArama.Controls.Add(this.label4);
            this.gboxGelismisArama.Controls.Add(this.label3);
            this.gboxGelismisArama.Controls.Add(this.txtSayfaSayisi);
            this.gboxGelismisArama.Controls.Add(this.txtISBNNo);
            this.gboxGelismisArama.Controls.Add(this.txtYayinYili);
            this.gboxGelismisArama.Controls.Add(this.txtKitapKodu);
            this.gboxGelismisArama.Controls.Add(this.txtKitapKategori);
            this.gboxGelismisArama.Controls.Add(this.txtKitapYazari);
            this.gboxGelismisArama.Controls.Add(this.txtKitapAdi);
            this.gboxGelismisArama.Enabled = false;
            this.gboxGelismisArama.Location = new System.Drawing.Point(294, 29);
            this.gboxGelismisArama.Name = "gboxGelismisArama";
            this.gboxGelismisArama.Size = new System.Drawing.Size(265, 257);
            this.gboxGelismisArama.TabIndex = 2;
            this.gboxGelismisArama.TabStop = false;
            this.gboxGelismisArama.Text = "Gelişmiş Arama";
            // 
            // cxboxBasitArama
            // 
            this.cxboxBasitArama.AutoSize = true;
            this.cxboxBasitArama.Checked = true;
            this.cxboxBasitArama.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cxboxBasitArama.Location = new System.Drawing.Point(113, 225);
            this.cxboxBasitArama.Name = "cxboxBasitArama";
            this.cxboxBasitArama.Size = new System.Drawing.Size(82, 17);
            this.cxboxBasitArama.TabIndex = 11;
            this.cxboxBasitArama.Text = "Basit Arama";
            this.cxboxBasitArama.UseVisualStyleBackColor = true;
            this.cxboxBasitArama.CheckedChanged += new System.EventHandler(this.cxboxBasitArama_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sayfa Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ISBN No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yayın Yılı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitap Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitap Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Adı:";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(113, 199);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(133, 20);
            this.txtSayfaSayisi.TabIndex = 10;
            // 
            // txtISBNNo
            // 
            this.txtISBNNo.Location = new System.Drawing.Point(113, 173);
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.Size = new System.Drawing.Size(133, 20);
            this.txtISBNNo.TabIndex = 9;
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.Location = new System.Drawing.Point(113, 147);
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(133, 20);
            this.txtYayinYili.TabIndex = 8;
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Location = new System.Drawing.Point(113, 121);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(133, 20);
            this.txtKitapKodu.TabIndex = 7;
            // 
            // txtKitapKategori
            // 
            this.txtKitapKategori.Location = new System.Drawing.Point(113, 95);
            this.txtKitapKategori.Name = "txtKitapKategori";
            this.txtKitapKategori.Size = new System.Drawing.Size(133, 20);
            this.txtKitapKategori.TabIndex = 6;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(113, 69);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(133, 20);
            this.txtKitapYazari.TabIndex = 5;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(113, 43);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(133, 20);
            this.txtKitapAdi.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgridBulunanKitaplar);
            this.groupBox4.Location = new System.Drawing.Point(6, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 345);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonuçlar";
            // 
            // dgridBulunanKitaplar
            // 
            this.dgridBulunanKitaplar.AllowUserToAddRows = false;
            this.dgridBulunanKitaplar.AllowUserToDeleteRows = false;
            this.dgridBulunanKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBulunanKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridBulunanKitaplar.Location = new System.Drawing.Point(3, 16);
            this.dgridBulunanKitaplar.Name = "dgridBulunanKitaplar";
            this.dgridBulunanKitaplar.ReadOnly = true;
            this.dgridBulunanKitaplar.Size = new System.Drawing.Size(573, 326);
            this.dgridBulunanKitaplar.TabIndex = 0;
            this.dgridBulunanKitaplar.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridBulunanKitaplar_RowHeaderMouseDoubleClick);
            // 
            // frmKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 725);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKitapListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitapListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gboxBasitArama.ResumeLayout(false);
            this.gboxBasitArama.PerformLayout();
            this.gboxGelismisArama.ResumeLayout(false);
            this.gboxGelismisArama.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridBulunanKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgridKitapListesi;
        private System.Windows.Forms.Button btnKitapListesiKapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gboxGelismisArama;
        private System.Windows.Forms.GroupBox gboxBasitArama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYayinYili;
        private System.Windows.Forms.TextBox txtKitapKodu;
        private System.Windows.Forms.TextBox txtKitapKategori;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.CheckBox cxboxGelismisArama;
        private System.Windows.Forms.CheckBox cxboxBasitArama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.TextBox txtISBNNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgridBulunanKitaplar;
    }
}