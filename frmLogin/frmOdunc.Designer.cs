namespace frmLogin
{
    partial class frmOdunc
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
            this.btnOduncBilgiSorgula = new System.Windows.Forms.Button();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.txtOgrenciNumaraAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridOduncBilgisi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOduncIptal = new System.Windows.Forms.Button();
            this.btnOduncOnay = new System.Windows.Forms.Button();
            this.txtOduncBilgi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridOduncBilgisi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOduncBilgiSorgula);
            this.groupBox1.Controls.Add(this.btnKitapAra);
            this.groupBox1.Controls.Add(this.btnOgrenciAra);
            this.groupBox1.Controls.Add(this.txtKitapAra);
            this.groupBox1.Controls.Add(this.txtOgrenciNumaraAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOduncBilgiSorgula
            // 
            this.btnOduncBilgiSorgula.Enabled = false;
            this.btnOduncBilgiSorgula.Location = new System.Drawing.Point(87, 77);
            this.btnOduncBilgiSorgula.Name = "btnOduncBilgiSorgula";
            this.btnOduncBilgiSorgula.Size = new System.Drawing.Size(192, 23);
            this.btnOduncBilgiSorgula.TabIndex = 4;
            this.btnOduncBilgiSorgula.Text = "Ödünç Bilgisi Sorgula";
            this.btnOduncBilgiSorgula.UseVisualStyleBackColor = true;
            this.btnOduncBilgiSorgula.Click += new System.EventHandler(this.btnOduncBilgiSorgula_Click);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Location = new System.Drawing.Point(285, 47);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(40, 23);
            this.btnKitapAra.TabIndex = 3;
            this.btnKitapAra.Text = "Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(285, 22);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(40, 23);
            this.btnOgrenciAra.TabIndex = 1;
            this.btnOgrenciAra.Text = "Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Enabled = false;
            this.txtKitapAra.Location = new System.Drawing.Point(87, 50);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(192, 20);
            this.txtKitapAra.TabIndex = 2;
            // 
            // txtOgrenciNumaraAra
            // 
            this.txtOgrenciNumaraAra.Location = new System.Drawing.Point(87, 24);
            this.txtOgrenciNumaraAra.Name = "txtOgrenciNumaraAra";
            this.txtOgrenciNumaraAra.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciNumaraAra.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridOduncBilgisi);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Bilgisi";
            // 
            // dgridOduncBilgisi
            // 
            this.dgridOduncBilgisi.AllowUserToAddRows = false;
            this.dgridOduncBilgisi.AllowUserToDeleteRows = false;
            this.dgridOduncBilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridOduncBilgisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridOduncBilgisi.Location = new System.Drawing.Point(3, 16);
            this.dgridOduncBilgisi.Name = "dgridOduncBilgisi";
            this.dgridOduncBilgisi.ReadOnly = true;
            this.dgridOduncBilgisi.Size = new System.Drawing.Size(332, 126);
            this.dgridOduncBilgisi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOduncIptal);
            this.groupBox3.Controls.Add(this.btnOduncOnay);
            this.groupBox3.Controls.Add(this.txtOduncBilgi);
            this.groupBox3.Location = new System.Drawing.Point(13, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Onay";
            // 
            // btnOduncIptal
            // 
            this.btnOduncIptal.Location = new System.Drawing.Point(264, 19);
            this.btnOduncIptal.Name = "btnOduncIptal";
            this.btnOduncIptal.Size = new System.Drawing.Size(61, 23);
            this.btnOduncIptal.TabIndex = 7;
            this.btnOduncIptal.Text = "İptal";
            this.btnOduncIptal.UseVisualStyleBackColor = true;
            this.btnOduncIptal.Click += new System.EventHandler(this.btnOduncIptal_Click);
            // 
            // btnOduncOnay
            // 
            this.btnOduncOnay.Enabled = false;
            this.btnOduncOnay.Location = new System.Drawing.Point(197, 19);
            this.btnOduncOnay.Name = "btnOduncOnay";
            this.btnOduncOnay.Size = new System.Drawing.Size(61, 23);
            this.btnOduncOnay.TabIndex = 6;
            this.btnOduncOnay.Text = "Onay";
            this.btnOduncOnay.UseVisualStyleBackColor = true;
            this.btnOduncOnay.Click += new System.EventHandler(this.btnOduncOnay_Click);
            // 
            // txtOduncBilgi
            // 
            this.txtOduncBilgi.Enabled = false;
            this.txtOduncBilgi.Location = new System.Drawing.Point(6, 21);
            this.txtOduncBilgi.Name = "txtOduncBilgi";
            this.txtOduncBilgi.Size = new System.Drawing.Size(176, 20);
            this.txtOduncBilgi.TabIndex = 5;
            // 
            // frmOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdunc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ödünç";
            this.Load += new System.EventHandler(this.frmOdunc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridOduncBilgisi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.TextBox txtOgrenciNumaraAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOduncBilgiSorgula;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOduncOnay;
        private System.Windows.Forms.TextBox txtOduncBilgi;
        private System.Windows.Forms.Button btnOduncIptal;
        private System.Windows.Forms.DataGridView dgridOduncBilgisi;
    }
}