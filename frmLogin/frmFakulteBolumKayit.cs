using EntityLogin;
using EntityLogin.Facade;
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
    public partial class frmFakulteBolumKayit : Form
    {
        public frmFakulteBolumKayit( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void frmFakulteBolumKayit_Load( object sender, EventArgs e )
        {
            List<Fakulte> list = DB.Fakulte.ToList();
            cboxFakulte.DisplayMember = "fakulteAd";
            cboxFakulte.ValueMember = "id";
            cboxFakulte.DataSource = list;
            cboxFakulte.Invalidate();
        }

        private void btnKapat_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnFakulteEkle_Click( object sender, EventArgs e )
        {
            Fakulte fakulte = new Fakulte();
            fakulte.fakulteAd = txtFakulte.Text;

            FakulteBolumFacade fakulteEkle = new FakulteBolumFacade();
            fakulteEkle.Ekle( fakulte );

            frmFakulteBolumKayit_Load( null, null );
        }

        private void btnBolumEkle_Click( object sender, EventArgs e )
        {
            Bolum bolum = new Bolum();
            bolum.bolumAd = txtBolum.Text;
            bolum.fakulteId = Convert.ToInt32( cboxFakulte.SelectedValue.ToString() );

            FakulteBolumFacade bolumEkle = new FakulteBolumFacade();
            bolumEkle.Ekle( bolum );

            frmFakulteBolumKayit_Load( null, null );
        }
    }
}
