namespace frmLogin
{
    partial class frmBulunanKitapGuncelleme
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
            this.dpicBulunanGuncellenecekKitapYayınYili = new System.Windows.Forms.DateTimePicker();
            this.btnBulunanKitapGuncellemeIptal = new System.Windows.Forms.Button();
            this.btnBulunanKitapGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBulunanGuncellenecekKitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBulunanGuncellenecekKitapISBN = new System.Windows.Forms.TextBox();
            this.txtBulunanGuncellenecekKitapYazari = new System.Windows.Forms.TextBox();
            this.txtBulunanGuncellenecekKitapKategori = new System.Windows.Forms.TextBox();
            this.txtBulunanGuncellenecekKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBulunanGuncellenecekKitapKodu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpicBulunanGuncellenecekKitapYayınYili);
            this.groupBox1.Controls.Add(this.btnBulunanKitapGuncellemeIptal);
            this.groupBox1.Controls.Add(this.btnBulunanKitapGuncelle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapISBN);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapYazari);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapKategori);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapAdi);
            this.groupBox1.Controls.Add(this.txtBulunanGuncellenecekKitapKodu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Güncelleme";
            // 
            // dpicBulunanGuncellenecekKitapYayınYili
            // 
            this.dpicBulunanGuncellenecekKitapYayınYili.CustomFormat = "dd-MM-yyyy";
            this.dpicBulunanGuncellenecekKitapYayınYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicBulunanGuncellenecekKitapYayınYili.Location = new System.Drawing.Point(141, 123);
            this.dpicBulunanGuncellenecekKitapYayınYili.Name = "dpicBulunanGuncellenecekKitapYayınYili";
            this.dpicBulunanGuncellenecekKitapYayınYili.Size = new System.Drawing.Size(192, 20);
            this.dpicBulunanGuncellenecekKitapYayınYili.TabIndex = 3;
            // 
            // btnBulunanKitapGuncellemeIptal
            // 
            this.btnBulunanKitapGuncellemeIptal.Location = new System.Drawing.Point(246, 227);
            this.btnBulunanKitapGuncellemeIptal.Name = "btnBulunanKitapGuncellemeIptal";
            this.btnBulunanKitapGuncellemeIptal.Size = new System.Drawing.Size(87, 23);
            this.btnBulunanKitapGuncellemeIptal.TabIndex = 2;
            this.btnBulunanKitapGuncellemeIptal.Text = "İptal";
            this.btnBulunanKitapGuncellemeIptal.UseVisualStyleBackColor = true;
            this.btnBulunanKitapGuncellemeIptal.Click += new System.EventHandler(this.btnBulunanKitapGuncellemeIptal_Click);
            // 
            // btnBulunanKitapGuncelle
            // 
            this.btnBulunanKitapGuncelle.Location = new System.Drawing.Point(141, 227);
            this.btnBulunanKitapGuncelle.Name = "btnBulunanKitapGuncelle";
            this.btnBulunanKitapGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnBulunanKitapGuncelle.TabIndex = 2;
            this.btnBulunanKitapGuncelle.Text = "Güncelle";
            this.btnBulunanKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnBulunanKitapGuncelle.Click += new System.EventHandler(this.btnBulunanKitapGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yayın Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap Kategorisi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Kodu:";
            // 
            // txtBulunanGuncellenecekKitapSayfaSayisi
            // 
            this.txtBulunanGuncellenecekKitapSayfaSayisi.Location = new System.Drawing.Point(141, 200);
            this.txtBulunanGuncellenecekKitapSayfaSayisi.Name = "txtBulunanGuncellenecekKitapSayfaSayisi";
            this.txtBulunanGuncellenecekKitapSayfaSayisi.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapSayfaSayisi.TabIndex = 0;
            // 
            // txtBulunanGuncellenecekKitapISBN
            // 
            this.txtBulunanGuncellenecekKitapISBN.Location = new System.Drawing.Point(141, 174);
            this.txtBulunanGuncellenecekKitapISBN.Name = "txtBulunanGuncellenecekKitapISBN";
            this.txtBulunanGuncellenecekKitapISBN.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapISBN.TabIndex = 0;
            // 
            // txtBulunanGuncellenecekKitapYazari
            // 
            this.txtBulunanGuncellenecekKitapYazari.Location = new System.Drawing.Point(141, 148);
            this.txtBulunanGuncellenecekKitapYazari.Name = "txtBulunanGuncellenecekKitapYazari";
            this.txtBulunanGuncellenecekKitapYazari.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapYazari.TabIndex = 0;
            // 
            // txtBulunanGuncellenecekKitapKategori
            // 
            this.txtBulunanGuncellenecekKitapKategori.Location = new System.Drawing.Point(141, 96);
            this.txtBulunanGuncellenecekKitapKategori.Name = "txtBulunanGuncellenecekKitapKategori";
            this.txtBulunanGuncellenecekKitapKategori.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapKategori.TabIndex = 0;
            // 
            // txtBulunanGuncellenecekKitapAdi
            // 
            this.txtBulunanGuncellenecekKitapAdi.Location = new System.Drawing.Point(141, 70);
            this.txtBulunanGuncellenecekKitapAdi.Name = "txtBulunanGuncellenecekKitapAdi";
            this.txtBulunanGuncellenecekKitapAdi.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapAdi.TabIndex = 0;
            // 
            // txtBulunanGuncellenecekKitapKodu
            // 
            this.txtBulunanGuncellenecekKitapKodu.Location = new System.Drawing.Point(141, 44);
            this.txtBulunanGuncellenecekKitapKodu.Name = "txtBulunanGuncellenecekKitapKodu";
            this.txtBulunanGuncellenecekKitapKodu.Size = new System.Drawing.Size(192, 20);
            this.txtBulunanGuncellenecekKitapKodu.TabIndex = 0;
            // 
            // frmBulunanKitapGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 351);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBulunanKitapGuncelleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Güncelleme";
            this.Load += new System.EventHandler(this.frmBulunanKitapGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBulunanKitapGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBulunanKitapGuncellemeIptal;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapSayfaSayisi;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapISBN;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapYazari;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapKategori;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapAdi;
        public System.Windows.Forms.TextBox txtBulunanGuncellenecekKitapKodu;
        public System.Windows.Forms.DateTimePicker dpicBulunanGuncellenecekKitapYayınYili;
    }
}