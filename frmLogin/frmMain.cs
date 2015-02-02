using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmMain : Form
    {
        public frmMain( )
        {
            InitializeComponent();
        }

        private void kitapKayıtToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmKitapKayit frmKitapKayit = new frmKitapKayit();
            frmKitapKayit.ShowDialog();
        }

        private void cikisToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult karar = MessageBox.Show( "Çıkış Yapmak İstediğinizden Emin misiniz ?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question );

            switch ( karar )
            {
                case DialogResult.OK:
                    {
                        this.Close();
                        break;
                    }
                case DialogResult.Cancel:
                    break;
            }

            
        }

        private void öğrenciKayıtToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmOgrenciKayit frmOgrenciKayit = new frmOgrenciKayit();
            frmOgrenciKayit.ShowDialog();
        }

        private void ödünçToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmOdunc frmOdunc = new frmOdunc();
            frmOdunc.ShowDialog();
        }

        private void teslimToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmTeslim frmTeslim = new frmTeslim();
            frmTeslim.ShowDialog();
        }

        private void öğrenciListesiToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmOgrenciListesi frmOgrenciListesi = new frmOgrenciListesi();
            frmOgrenciListesi.ShowDialog();
        }

        private void kitapListesiToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmKitapListesi frmKitapListesi = new frmKitapListesi();
            frmKitapListesi.ShowDialog();
        }

        private void ödünçRaporuToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmOduncRapor frmOduncRapor = new frmOduncRapor();
            frmOduncRapor.ShowDialog();
        }

        private void fakülteBölümKayıtToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmFakulteBolumKayit frmFakulteBolumKayit = new frmFakulteBolumKayit();
            frmFakulteBolumKayit.ShowDialog();
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            
        }

        private void menuStrip1_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {

        }
    }
}
