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
    public partial class frmKitapGuncelle : Form
    {
        public frmKitapGuncelle( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        Kitaplar kitap = new Kitaplar();
        

        private void frmKitapGuncelle_Load( object sender, EventArgs e )
        {
            var id = from a in DB.Kitaplar
                     where a.kitapAdi == txtKitapAdi.Text
                     select a.id;

            foreach ( var item in id )
            {
                kitap.id = Convert.ToInt32( item );
                break;
            }
        }

        private void btnKitapGuncelle_Click( object sender, EventArgs e )
        {
            kitap.kitapKodu = txtKitapKodu.Text;
            kitap.kitapAdi = txtKitapAdi.Text;
            kitap.kategori = txtKitapKategori.Text;
            kitap.yayinYili = dpicYayinYili.Value;
            kitap.yazari = txtYazar.Text;
            kitap.ISBN = txtISBN.Text;
            kitap.sayfaSayisi = Convert.ToInt16(txtSayfaSayisi.Text);

            KitapGuncelleFacade kitapGuncelle = new KitapGuncelleFacade();
            kitapGuncelle.Guncelle( kitap );

            this.Close();
        }
        
        
        private void btnKitapGuncelleIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        
    }
}
