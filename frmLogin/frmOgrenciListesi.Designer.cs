namespace frmLogin
{
    partial class frmOgrenciListesi
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
            this.dgridOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.btnOgrenciListesiKapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgridAramaSonuclar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.txtCepTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFakulteBolumAra = new System.Windows.Forms.Button();
            this.cboxBolum = new System.Windows.Forms.ComboBox();
            this.cboxFakulte = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridOgrenciListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridAramaSonuclar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridOgrenciListesi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenciler";
            // 
            // dgridOgrenciListesi
            // 
            this.dgridOgrenciListesi.AllowUserToOrderColumns = true;
            this.dgridOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridOgrenciListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridOgrenciListesi.Location = new System.Drawing.Point(3, 16);
            this.dgridOgrenciListesi.Name = "dgridOgrenciListesi";
            this.dgridOgrenciListesi.Size = new System.Drawing.Size(934, 714);
            this.dgridOgrenciListesi.TabIndex = 0;
            this.dgridOgrenciListesi.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridOgrenciListesi_RowHeaderMouseDoubleClick);
            // 
            // btnOgrenciListesiKapat
            // 
            this.btnOgrenciListesiKapat.Location = new System.Drawing.Point(322, 712);
            this.btnOgrenciListesiKapat.Name = "btnOgrenciListesiKapat";
            this.btnOgrenciListesiKapat.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciListesiKapat.TabIndex = 1;
            this.btnOgrenciListesiKapat.Text = "Kapat";
            this.btnOgrenciListesiKapat.UseVisualStyleBackColor = true;
            this.btnOgrenciListesiKapat.Click += new System.EventHandler(this.btnOgrenciListesiKapat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnOgrenciListesiKapat);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(962, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 741);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgridAramaSonuclar);
            this.groupBox5.Location = new System.Drawing.Point(6, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 448);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arama Sonuçları";
            // 
            // dgridAramaSonuclar
            // 
            this.dgridAramaSonuclar.AllowUserToAddRows = false;
            this.dgridAramaSonuclar.AllowUserToDeleteRows = false;
            this.dgridAramaSonuclar.AllowUserToOrderColumns = true;
            this.dgridAramaSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAramaSonuclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridAramaSonuclar.Location = new System.Drawing.Point(3, 16);
            this.dgridAramaSonuclar.Name = "dgridAramaSonuclar";
            this.dgridAramaSonuclar.ReadOnly = true;
            this.dgridAramaSonuclar.Size = new System.Drawing.Size(388, 429);
            this.dgridAramaSonuclar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOgrenciAra);
            this.groupBox4.Controls.Add(this.txtCepTelefon);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox4.Controls.Add(this.txtOgrenciAd);
            this.groupBox4.Controls.Add(this.txtOgrenciNo);
            this.groupBox4.Location = new System.Drawing.Point(6, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 148);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci";
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(287, 19);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(101, 101);
            this.btnOgrenciAra.TabIndex = 4;
            this.btnOgrenciAra.Text = "Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // txtCepTelefon
            // 
            this.txtCepTelefon.Location = new System.Drawing.Point(160, 100);
            this.txtCepTelefon.Name = "txtCepTelefon";
            this.txtCepTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtCepTelefon.TabIndex = 3;
            this.txtCepTelefon.TextChanged += new System.EventHandler(this.txtCepTelefon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cep Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrenci Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No:";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(160, 74);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtOgrenciSoyad.TabIndex = 0;
            this.txtOgrenciSoyad.TextChanged += new System.EventHandler(this.txtOgrenciSoyad_TextChanged);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(160, 48);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(121, 20);
            this.txtOgrenciAd.TabIndex = 0;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.txtOgrenciAd_TextChanged);
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(160, 22);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(121, 20);
            this.txtOgrenciNo.TabIndex = 0;
            this.txtOgrenciNo.TextChanged += new System.EventHandler(this.txtOgrenciNo_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFakulteBolumAra);
            this.groupBox3.Controls.Add(this.cboxBolum);
            this.groupBox3.Controls.Add(this.cboxFakulte);
            this.groupBox3.Location = new System.Drawing.Point(6, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fakülte-Bölüm";
            // 
            // btnFakulteBolumAra
            // 
            this.btnFakulteBolumAra.Location = new System.Drawing.Point(287, 17);
            this.btnFakulteBolumAra.Name = "btnFakulteBolumAra";
            this.btnFakulteBolumAra.Size = new System.Drawing.Size(101, 23);
            this.btnFakulteBolumAra.TabIndex = 2;
            this.btnFakulteBolumAra.Text = "Ara";
            this.btnFakulteBolumAra.UseVisualStyleBackColor = true;
            this.btnFakulteBolumAra.Click += new System.EventHandler(this.btnFakulteBolumAra_Click);
            // 
            // cboxBolum
            // 
            this.cboxBolum.FormattingEnabled = true;
            this.cboxBolum.Location = new System.Drawing.Point(160, 19);
            this.cboxBolum.Name = "cboxBolum";
            this.cboxBolum.Size = new System.Drawing.Size(121, 21);
            this.cboxBolum.TabIndex = 1;
            // 
            // cboxFakulte
            // 
            this.cboxFakulte.FormattingEnabled = true;
            this.cboxFakulte.Location = new System.Drawing.Point(33, 19);
            this.cboxFakulte.Name = "cboxFakulte";
            this.cboxFakulte.Size = new System.Drawing.Size(121, 21);
            this.cboxFakulte.TabIndex = 0;
            this.cboxFakulte.SelectedIndexChanged += new System.EventHandler(this.cboxFakulte_SelectedIndexChanged);
            // 
            // frmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOgrenciListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridOgrenciListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAramaSonuclar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrenciListesiKapat;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgridOgrenciListesi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.TextBox txtCepTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Button btnFakulteBolumAra;
        private System.Windows.Forms.ComboBox cboxBolum;
        private System.Windows.Forms.ComboBox cboxFakulte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgridAramaSonuclar;
    }
}