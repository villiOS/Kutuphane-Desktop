namespace frmLogin
{
    partial class frmOgrenciKayit
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
            this.cboxBolum = new System.Windows.Forms.ComboBox();
            this.cboxFakulte = new System.Windows.Forms.ComboBox();
            this.dpicKayitTarih = new System.Windows.Forms.DateTimePicker();
            this.btnOgrenciKayitIptal = new System.Windows.Forms.Button();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.txtCepTelefon = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.cboxBolum);
            this.groupBox1.Controls.Add(this.cboxFakulte);
            this.groupBox1.Controls.Add(this.dpicKayitTarih);
            this.groupBox1.Controls.Add(this.btnOgrenciKayitIptal);
            this.groupBox1.Controls.Add(this.btnOgrenciKaydet);
            this.groupBox1.Controls.Add(this.txtCepTelefon);
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
            this.groupBox1.Size = new System.Drawing.Size(354, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt";
            // 
            // cboxBolum
            // 
            this.cboxBolum.FormattingEnabled = true;
            this.cboxBolum.Location = new System.Drawing.Point(142, 138);
            this.cboxBolum.Name = "cboxBolum";
            this.cboxBolum.Size = new System.Drawing.Size(192, 21);
            this.cboxBolum.TabIndex = 4;
            // 
            // cboxFakulte
            // 
            this.cboxFakulte.DisplayMember = "fakulteAd";
            this.cboxFakulte.FormattingEnabled = true;
            this.cboxFakulte.Location = new System.Drawing.Point(142, 112);
            this.cboxFakulte.Name = "cboxFakulte";
            this.cboxFakulte.Size = new System.Drawing.Size(192, 21);
            this.cboxFakulte.TabIndex = 3;
            this.cboxFakulte.ValueMember = "fakulteAd";
            this.cboxFakulte.SelectedIndexChanged += new System.EventHandler(this.cboxFakulte_SelectedIndexChanged);
            // 
            // dpicKayitTarih
            // 
            this.dpicKayitTarih.CustomFormat = "dd-MM-yyyy";
            this.dpicKayitTarih.Enabled = false;
            this.dpicKayitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpicKayitTarih.Location = new System.Drawing.Point(142, 217);
            this.dpicKayitTarih.Name = "dpicKayitTarih";
            this.dpicKayitTarih.Size = new System.Drawing.Size(192, 20);
            this.dpicKayitTarih.TabIndex = 7;
            // 
            // btnOgrenciKayitIptal
            // 
            this.btnOgrenciKayitIptal.Location = new System.Drawing.Point(247, 269);
            this.btnOgrenciKayitIptal.Name = "btnOgrenciKayitIptal";
            this.btnOgrenciKayitIptal.Size = new System.Drawing.Size(87, 23);
            this.btnOgrenciKayitIptal.TabIndex = 10;
            this.btnOgrenciKayitIptal.Text = "İptal";
            this.btnOgrenciKayitIptal.UseVisualStyleBackColor = true;
            this.btnOgrenciKayitIptal.Click += new System.EventHandler(this.btnOgrenciKayitIptal_Click);
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(142, 270);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(87, 23);
            this.btnOgrenciKaydet.TabIndex = 9;
            this.btnOgrenciKaydet.Text = "Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // txtCepTelefon
            // 
            this.txtCepTelefon.Location = new System.Drawing.Point(142, 243);
            this.txtCepTelefon.Name = "txtCepTelefon";
            this.txtCepTelefon.Size = new System.Drawing.Size(192, 20);
            this.txtCepTelefon.TabIndex = 8;
            // 
            // txtMemleketAdres
            // 
            this.txtMemleketAdres.Location = new System.Drawing.Point(142, 191);
            this.txtMemleketAdres.Multiline = true;
            this.txtMemleketAdres.Name = "txtMemleketAdres";
            this.txtMemleketAdres.Size = new System.Drawing.Size(192, 20);
            this.txtMemleketAdres.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(142, 165);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(192, 20);
            this.txtAdres.TabIndex = 5;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(142, 87);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciSoyad.TabIndex = 2;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(142, 61);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(142, 35);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciNo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cep Telefonu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kayıt Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Memleket Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fakülte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // frmOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 363);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.frmOgrenciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCepTelefon;
        private System.Windows.Forms.TextBox txtMemleketAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Button btnOgrenciKayitIptal;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.DateTimePicker dpicKayitTarih;
        private System.Windows.Forms.ComboBox cboxFakulte;
        private System.Windows.Forms.ComboBox cboxBolum;
    }
}