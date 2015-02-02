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
    public partial class frmBulunanKitapGuncelleme : Form
    {
        public frmBulunanKitapGuncelleme( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        Kitaplar bulunanGuncellenecekKitap = new Kitaplar();

      
        private void btnBulunanKitapGuncelle_Click( object sender, EventArgs e )
        {
            bulunanGuncellenecekKitap.kitapKodu = txtBulunanGuncellenecekKitapKodu.Text;
            bulunanGuncellenecekKitap.kitapAdi = txtBulunanGuncellenecekKitapAdi.Text;
            bulunanGuncellenecekKitap.kategori = txtBulunanGuncellenecekKitapKategori.Text;
            bulunanGuncellenecekKitap.yayinYili = dpicBulunanGuncellenecekKitapYayınYili.Value;
            bulunanGuncellenecekKitap.yazari = txtBulunanGuncellenecekKitapYazari.Text;
            bulunanGuncellenecekKitap.ISBN = txtBulunanGuncellenecekKitapISBN.Text;
            bulunanGuncellenecekKitap.sayfaSayisi = Convert.ToInt16(txtBulunanGuncellenecekKitapSayfaSayisi.Text);

            KitapGuncelleFacade bulunanKitapGuncelle = new KitapGuncelleFacade();
            bulunanKitapGuncelle.Guncelle( bulunanGuncellenecekKitap );


            this.Close();
        }

        private void btnBulunanKitapGuncellemeIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmBulunanKitapGuncelleme_Load( object sender, EventArgs e )
        {
            var id = from a in DB.Kitaplar
                     where a.kitapAdi == txtBulunanGuncellenecekKitapAdi.Text
                     select a.id;

            foreach ( var item in id )
            {
                bulunanGuncellenecekKitap.id = Convert.ToInt32( item );
                break;
            }
        }
    }
}
