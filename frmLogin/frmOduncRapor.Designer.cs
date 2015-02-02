namespace frmLogin
{
    partial class frmOduncRapor
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
            this.dgridOduncTablo = new System.Windows.Forms.DataGridView();
            this.btnOduncRaporKapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKitabaGoreSorgula = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtKitapKodu = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciyeGoreSorgula = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtCepTelefonu = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridOduncTablo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridOduncTablo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Tablosu";
            // 
            // dgridOduncTablo
            // 
            this.dgridOduncTablo.AllowUserToAddRows = false;
            this.dgridOduncTablo.AllowUserToDeleteRows = false;
            this.dgridOduncTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridOduncTablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridOduncTablo.Location = new System.Drawing.Point(3, 16);
            this.dgridOduncTablo.Name = "dgridOduncTablo";
            this.dgridOduncTablo.ReadOnly = true;
            this.dgridOduncTablo.Size = new System.Drawing.Size(837, 516);
            this.dgridOduncTablo.TabIndex = 0;
            // 
            // btnOduncRaporKapat
            // 
            this.btnOduncRaporKapat.Location = new System.Drawing.Point(1085, 524);
            this.btnOduncRaporKapat.Name = "btnOduncRaporKapat";
            this.btnOduncRaporKapat.Size = new System.Drawing.Size(75, 23);
            this.btnOduncRaporKapat.TabIndex = 1;
            this.btnOduncRaporKapat.Text = "Kapat";
            this.btnOduncRaporKapat.UseVisualStyleBackColor = true;
            this.btnOduncRaporKapat.Click += new System.EventHandler(this.btnOduncRaporKapat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(878, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 506);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç/Teslim Bilgi Sorgulama";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKitabaGoreSorgula);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtKategori);
            this.groupBox4.Controls.Add(this.txtKitapKodu);
            this.groupBox4.Controls.Add(this.txtSayfaSayisi);
            this.groupBox4.Controls.Add(this.txtISBN);
            this.groupBox4.Controls.Add(this.txtKitapYazari);
            this.groupBox4.Controls.Add(this.txtKitapAdi);
            this.groupBox4.Location = new System.Drawing.Point(7, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 227);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitaba Göre Sorgulama";
            // 
            // btnKitabaGoreSorgula
            // 
            this.btnKitabaGoreSorgula.Location = new System.Drawing.Point(98, 186);
            this.btnKitabaGoreSorgula.Name = "btnKitabaGoreSorgula";
            this.btnKitabaGoreSorgula.Size = new System.Drawing.Size(165, 23);
            this.btnKitabaGoreSorgula.TabIndex = 3;
            this.btnKitabaGoreSorgula.Text = "Ara";
            this.btnKitabaGoreSorgula.UseVisualStyleBackColor = true;
            this.btnKitabaGoreSorgula.Click += new System.EventHandler(this.btnKitabaGoreSorgula_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Sayfa Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kitap Yazarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitap Kodu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kitap Adı:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(96, 108);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(165, 20);
            this.txtKategori.TabIndex = 1;
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Location = new System.Drawing.Point(96, 30);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(165, 20);
            this.txtKitapKodu.TabIndex = 1;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(97, 160);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(165, 20);
            this.txtSayfaSayisi.TabIndex = 1;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(97, 134);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(165, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(97, 82);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(165, 20);
            this.txtKitapYazari.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(97, 56);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(165, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOgrenciyeGoreSorgula);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtFakulte);
            this.groupBox3.Controls.Add(this.txtBolum);
            this.groupBox3.Controls.Add(this.txtCepTelefonu);
            this.groupBox3.Controls.Add(this.txtOgrenciSoyadi);
            this.groupBox3.Controls.Add(this.txtOgrenciAdi);
            this.groupBox3.Controls.Add(this.txtOgrenciNo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 222);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenciye Göre Sorgulama";
            // 
            // btnOgrenciyeGoreSorgula
            // 
            this.btnOgrenciyeGoreSorgula.Location = new System.Drawing.Point(99, 188);
            this.btnOgrenciyeGoreSorgula.Name = "btnOgrenciyeGoreSorgula";
            this.btnOgrenciyeGoreSorgula.Size = new System.Drawing.Size(165, 23);
            this.btnOgrenciyeGoreSorgula.TabIndex = 3;
            this.btnOgrenciyeGoreSorgula.Text = "Ara";
            this.btnOgrenciyeGoreSorgula.UseVisualStyleBackColor = true;
            this.btnOgrenciyeGoreSorgula.Click += new System.EventHandler(this.btnOgrenciyeGoreSorgula_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fakülte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bölüm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cep Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // txtFakulte
            // 
            this.txtFakulte.Location = new System.Drawing.Point(99, 162);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(165, 20);
            this.txtFakulte.TabIndex = 1;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(99, 136);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(165, 20);
            this.txtBolum.TabIndex = 1;
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(99, 110);
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(165, 20);
            this.txtCepTelefonu.TabIndex = 1;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(99, 84);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(165, 20);
            this.txtOgrenciSoyadi.TabIndex = 1;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(99, 58);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(165, 20);
            this.txtOgrenciAdi.TabIndex = 1;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(98, 32);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(165, 20);
            this.txtOgrenciNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // frmOduncRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 551);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOduncRaporKapat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOduncRapor";
            this.ShowIcon = false;
            this.Text = "Ödünç Raporu";
            this.Load += new System.EventHandler(this.frmOduncRapor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridOduncTablo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOduncRaporKapat;
        private System.Windows.Forms.DataGridView dgridOduncTablo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKitabaGoreSorgula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtKitapKodu;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Button btnOgrenciyeGoreSorgula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtCepTelefonu;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
    }
}