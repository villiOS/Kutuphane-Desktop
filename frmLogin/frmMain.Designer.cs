namespace frmLogin
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapÖdünçTeslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakülteBölümKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKayıtToolStripMenuItem,
            this.öğrenciKayıtToolStripMenuItem,
            this.kitapÖdünçTeslimToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.kitapListesiToolStripMenuItem,
            this.fakülteBölümKayıtToolStripMenuItem,
            this.ödünçRaporuToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap Kayıt";
            this.kitapKayıtToolStripMenuItem.Click += new System.EventHandler(this.kitapKayıtToolStripMenuItem_Click);
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Kayıt";
            this.öğrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKayıtToolStripMenuItem_Click);
            // 
            // kitapÖdünçTeslimToolStripMenuItem
            // 
            this.kitapÖdünçTeslimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödünçToolStripMenuItem,
            this.teslimToolStripMenuItem});
            this.kitapÖdünçTeslimToolStripMenuItem.Name = "kitapÖdünçTeslimToolStripMenuItem";
            this.kitapÖdünçTeslimToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.kitapÖdünçTeslimToolStripMenuItem.Text = "Kitap Ödünç-Teslim";
            // 
            // ödünçToolStripMenuItem
            // 
            this.ödünçToolStripMenuItem.Name = "ödünçToolStripMenuItem";
            this.ödünçToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ödünçToolStripMenuItem.Text = "Ödünç";
            this.ödünçToolStripMenuItem.Click += new System.EventHandler(this.ödünçToolStripMenuItem_Click);
            // 
            // teslimToolStripMenuItem
            // 
            this.teslimToolStripMenuItem.Name = "teslimToolStripMenuItem";
            this.teslimToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.teslimToolStripMenuItem.Text = "Teslim";
            this.teslimToolStripMenuItem.Click += new System.EventHandler(this.teslimToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.kitapListesiToolStripMenuItem.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem_Click);
            // 
            // fakülteBölümKayıtToolStripMenuItem
            // 
            this.fakülteBölümKayıtToolStripMenuItem.Name = "fakülteBölümKayıtToolStripMenuItem";
            this.fakülteBölümKayıtToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.fakülteBölümKayıtToolStripMenuItem.Text = "Fakülte-Bölüm Kayıt";
            this.fakülteBölümKayıtToolStripMenuItem.Click += new System.EventHandler(this.fakülteBölümKayıtToolStripMenuItem_Click);
            // 
            // ödünçRaporuToolStripMenuItem
            // 
            this.ödünçRaporuToolStripMenuItem.Name = "ödünçRaporuToolStripMenuItem";
            this.ödünçRaporuToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ödünçRaporuToolStripMenuItem.Text = "Ödünç Raporu";
            this.ödünçRaporuToolStripMenuItem.Click += new System.EventHandler(this.ödünçRaporuToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 363);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapÖdünçTeslimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakülteBölümKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçRaporuToolStripMenuItem;


    }
}