namespace frmLogin
{
    partial class frmKitapGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapKodu = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapKategori = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.dpicYayinYili = new System.Windows.Forms.DateTimePicker();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapGuncelleIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapGuncelleIptal);
            this.groupBox1.Controls.Add(this.btnKitapGuncelle);
            this.groupBox1.Controls.Add(this.dpicYayinYili);
            this.groupBox1.Controls.Add(this.txtSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtKitapKategori);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.txtKitapKodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgi Güncelleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Kategorisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yayın Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Location = new System.Drawing.Point(140, 41);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(192, 20);
            this.txtKitapKodu.TabIndex = 0;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(140, 67);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(192, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtKitapKategori
            // 
            this.txtKitapKategori.Location = new System.Drawing.Point(140, 93);
            this.txtKitapKategori.Name = "txtKitapKategori";
            this.txtKitapKategori.Size = new System.Drawing.Size(192, 20);
            this.txtKitapKategori.TabIndex = 2;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(140, 145);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(192, 20);
            this.txtYazar.TabIndex = 4;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(140, 171);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(192, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(140, 197);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(192, 20);
            this.txtSayfaSayisi.TabIndex = 6;
            // 
            // dpicYayinYili
            // 
            this.dpicYayinYili.CustomFormat = "dd-MM-yyyy";
            this.dpicYayinYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicYayinYili.Location = new System.Drawing.Point(140, 119);
            this.dpicYayinYili.Name = "dpicYayinYili";
            this.dpicYayinYili.Size = new System.Drawing.Size(192, 20);
            this.dpicYayinYili.TabIndex = 3;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(140, 224);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnKitapGuncelle.TabIndex = 7;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapGuncelleIptal
            // 
            this.btnKitapGuncelleIptal.Location = new System.Drawing.Point(245, 223);
            this.btnKitapGuncelleIptal.Name = "btnKitapGuncelleIptal";
            this.btnKitapGuncelleIptal.Size = new System.Drawing.Size(87, 23);
            this.btnKitapGuncelleIptal.TabIndex = 8;
            this.btnKitapGuncelleIptal.Text = "İptal";
            this.btnKitapGuncelleIptal.UseVisualStyleBackColor = true;
            this.btnKitapGuncelleIptal.Click += new System.EventHandler(this.btnKitapGuncelleIptal_Click);
            // 
            // frmKitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 363);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapGuncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Güncelle";
            this.Load += new System.EventHandler(this.frmKitapGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKitapGuncelleIptal;
        private System.Windows.Forms.Button btnKitapGuncelle;
        public System.Windows.Forms.TextBox txtKitapKodu;
        public System.Windows.Forms.DateTimePicker dpicYayinYili;
        public System.Windows.Forms.TextBox txtSayfaSayisi;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.TextBox txtYazar;
        public System.Windows.Forms.TextBox txtKitapKategori;
        public System.Windows.Forms.TextBox txtKitapAdi;
    }
}