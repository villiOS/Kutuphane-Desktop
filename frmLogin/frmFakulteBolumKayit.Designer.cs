namespace frmLogin
{
    partial class frmFakulteBolumKayit
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
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.btnFakulteEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxFakulte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte Adı:";
            // 
            // txtFakulte
            // 
            this.txtFakulte.Location = new System.Drawing.Point(88, 34);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(157, 20);
            this.txtFakulte.TabIndex = 1;
            // 
            // btnFakulteEkle
            // 
            this.btnFakulteEkle.Location = new System.Drawing.Point(251, 32);
            this.btnFakulteEkle.Name = "btnFakulteEkle";
            this.btnFakulteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnFakulteEkle.TabIndex = 2;
            this.btnFakulteEkle.Text = "Ekle";
            this.btnFakulteEkle.UseVisualStyleBackColor = true;
            this.btnFakulteEkle.Click += new System.EventHandler(this.btnFakulteEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnFakulteEkle);
            this.groupBox2.Controls.Add(this.txtFakulte);
            this.groupBox2.Location = new System.Drawing.Point(6, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fakülte Ekle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBolumEkle);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBolum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cboxFakulte);
            this.groupBox3.Location = new System.Drawing.Point(6, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bölüm Ekle";
            // 
            // cboxFakulte
            // 
            this.cboxFakulte.FormattingEnabled = true;
            this.cboxFakulte.Location = new System.Drawing.Point(88, 50);
            this.cboxFakulte.Name = "cboxFakulte";
            this.cboxFakulte.Size = new System.Drawing.Size(157, 21);
            this.cboxFakulte.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fakülte Seç:";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(88, 77);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(157, 20);
            this.txtBolum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bölüm Adı:";
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(251, 74);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBolumEkle.TabIndex = 4;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(270, 345);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmFakulteBolumKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 380);
            this.ControlBox = false;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFakulteBolumKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakülte-Bölüm Kaydı";
            this.Load += new System.EventHandler(this.frmFakulteBolumKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxFakulte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFakulteEkle;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.Button btnKapat;
    }
}