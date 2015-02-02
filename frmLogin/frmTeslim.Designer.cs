namespace frmLogin
{
    partial class frmTeslim
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
            this.dgridKitapTeslim = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapTeslimOnay = new System.Windows.Forms.Button();
            this.btnTeslimIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitapTeslim)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridKitapTeslim);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Teslim";
            // 
            // dgridKitapTeslim
            // 
            this.dgridKitapTeslim.AllowUserToAddRows = false;
            this.dgridKitapTeslim.AllowUserToDeleteRows = false;
            this.dgridKitapTeslim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKitapTeslim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridKitapTeslim.Location = new System.Drawing.Point(3, 16);
            this.dgridKitapTeslim.Name = "dgridKitapTeslim";
            this.dgridKitapTeslim.ReadOnly = true;
            this.dgridKitapTeslim.Size = new System.Drawing.Size(332, 184);
            this.dgridKitapTeslim.TabIndex = 0;
            this.dgridKitapTeslim.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridKitapTeslim_RowHeaderMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOgrenciAra);
            this.groupBox2.Controls.Add(this.txtOgrenciAdi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ara:";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(89, 25);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(192, 20);
            this.txtOgrenciAdi.TabIndex = 1;
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(287, 24);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(45, 23);
            this.btnOgrenciAra.TabIndex = 2;
            this.btnOgrenciAra.Text = "Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTeslimIptal);
            this.groupBox3.Controls.Add(this.btnKitapTeslimOnay);
            this.groupBox3.Location = new System.Drawing.Point(15, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teslim Onay";
            // 
            // btnKitapTeslimOnay
            // 
            this.btnKitapTeslimOnay.Location = new System.Drawing.Point(86, 22);
            this.btnKitapTeslimOnay.Name = "btnKitapTeslimOnay";
            this.btnKitapTeslimOnay.Size = new System.Drawing.Size(75, 23);
            this.btnKitapTeslimOnay.TabIndex = 0;
            this.btnKitapTeslimOnay.Text = "Teslim Al";
            this.btnKitapTeslimOnay.UseVisualStyleBackColor = true;
            this.btnKitapTeslimOnay.Click += new System.EventHandler( this.btnKitapTeslimOnay_Click );
            // 
            // btnTeslimIptal
            // 
            this.btnTeslimIptal.Location = new System.Drawing.Point(178, 22);
            this.btnTeslimIptal.Name = "btnTeslimIptal";
            this.btnTeslimIptal.Size = new System.Drawing.Size(75, 23);
            this.btnTeslimIptal.TabIndex = 1;
            this.btnTeslimIptal.Text = "İptal";
            this.btnTeslimIptal.UseVisualStyleBackColor = true;
            this.btnTeslimIptal.Click += new System.EventHandler(this.btnTeslimIptal_Click);
            // 
            // frmTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 363);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeslim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitapTeslim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgridKitapTeslim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTeslimIptal;
        private System.Windows.Forms.Button btnKitapTeslimOnay;
    }
}