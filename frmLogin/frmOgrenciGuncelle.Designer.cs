namespace frmLogin
{
    partial class frmOgrenciGuncelle
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
            this.dpicKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.cboxBolum = new System.Windows.Forms.ComboBox();
            this.cboxFakulte = new System.Windows.Forms.ComboBox();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciKayitIptal = new System.Windows.Forms.Button();
            this.txtCepTelefonu = new System.Windows.Forms.TextBox();
            this.txtMemleketAdres = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpicKayitTarihi);
            this.groupBox1.Controls.Add(this.cboxBolum);
            this.groupBox1.Controls.Add(this.cboxFakulte);
            this.groupBox1.Controls.Add(this.btnOgrenciGuncelle);
            this.groupBox1.Controls.Add(this.btnOgrenciKayitIptal);
            this.groupBox1.Controls.Add(this.txtCepTelefonu);
            this.groupBox1.Controls.Add(this.txtMemleketAdres);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgi Güncelleme";
            // 
            // dpicKayitTarihi
            // 
            this.dpicKayitTarihi.CustomFormat = "dd-MM-yyyy";
            this.dpicKayitTarihi.Enabled = false;
            this.dpicKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicKayitTarihi.Location = new System.Drawing.Point(141, 224);
            this.dpicKayitTarihi.Name = "dpicKayitTarihi";
            this.dpicKayitTarihi.Size = new System.Drawing.Size(192, 20);
            this.dpicKayitTarihi.TabIndex = 7;
            // 
            // cboxBolum
            // 
            this.cboxBolum.FormattingEnabled = true;
            this.cboxBolum.Location = new System.Drawing.Point(141, 144);
            this.cboxBolum.Name = "cboxBolum";
            this.cboxBolum.Size = new System.Drawing.Size(192, 21);
            this.cboxBolum.TabIndex = 4;
            // 
            // cboxFakulte
            // 
            this.cboxFakulte.FormattingEnabled = true;
            this.cboxFakulte.Location = new System.Drawing.Point(141, 119);
            this.cboxFakulte.Name = "cboxFakulte";
            this.cboxFakulte.Size = new System.Drawing.Size(192, 21);
            this.cboxFakulte.TabIndex = 3;
            this.cboxFakulte.SelectedIndexChanged += new System.EventHandler(this.cboxFakulte_SelectedIndexChanged);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(141, 275);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(87, 23);
            this.btnOgrenciGuncelle.TabIndex = 9;
            this.btnOgrenciGuncelle.Text = "Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciKayitIptal
            // 
            this.btnOgrenciKayitIptal.Location = new System.Drawing.Point(246, 275);
            this.btnOgrenciKayitIptal.Name = "btnOgrenciKayitIptal";
            this.btnOgrenciKayitIptal.Size = new System.Drawing.Size(87, 23);
            this.btnOgrenciKayitIptal.TabIndex = 10;
            this.btnOgrenciKayitIptal.Text = "İptal";
            this.btnOgrenciKayitIptal.UseVisualStyleBackColor = true;
            this.btnOgrenciKayitIptal.Click += new System.EventHandler(this.btnOgrenciKayitIptal_Click);
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(141, 249);
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(192, 20);
            this.txtCepTelefonu.TabIndex = 8;
            // 
            // txtMemleketAdres
            // 
            this.txtMemleketAdres.Location = new System.Drawing.Point(141, 197);
            this.txtMemleketAdres.Name = "txtMemleketAdres";
            this.txtMemleketAdres.Size = new System.Drawing.Size(192, 20);
            this.txtMemleketAdres.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(141, 171);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(192, 20);
            this.txtAdres.TabIndex = 5;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(141, 93);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciSoyad.TabIndex = 2;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(141, 67);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(141, 41);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciNo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cep Telefonu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kayıt Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Memleket Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fakülte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // frmOgrenciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 361);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciGuncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOgrenciGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.frmOgrenciGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciKayitIptal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtOgrenciNo;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtCepTelefonu;
        public System.Windows.Forms.TextBox txtMemleketAdres;
        public System.Windows.Forms.TextBox txtOgrenciSoyad;
        public System.Windows.Forms.TextBox txtOgrenciAd;
        public System.Windows.Forms.DateTimePicker dpicKayitTarihi;
        public System.Windows.Forms.ComboBox cboxBolum;
        public System.Windows.Forms.ComboBox cboxFakulte;
    }
}