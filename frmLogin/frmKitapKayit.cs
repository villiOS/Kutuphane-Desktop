using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLogin;
using EntityLogin.Facade;

namespace frmLogin
{
    public partial class frmKitapKayit : Form
    {
        public frmKitapKayit( )
        {
            InitializeComponent();
        }

       

        private void btnKitapKayitIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnKitapKaydet_Click( object sender, EventArgs e )
        {
            //Değerlerin Kullanıcı Arayüzünden Alınması
            Kitaplar kitap = new Kitaplar();
            kitap.kitapKodu = txtKitapKodu.Text;
            kitap.kitapAdi = txtKitapAdi.Text;
            kitap.kategori = txtKategori.Text;
            kitap.yayinYili = dpicYayinYili.Value;
            kitap.yazari = txtYazari.Text;
            kitap.ISBN = txtISBN.Text;
            kitap.sayfaSayisi = Convert.ToInt16( txtSayfaSayisi.Text );
            //kitapEkle.AnahtarKelime = txtAnahtarKelime.Text;
            ///////////////////////////////////////////////////////

            
            
            //Alınan Kitap Verilerinin Veritabanına eklenmesi
            KitapFacade kitaplariTabloya = new KitapFacade();
            kitaplariTabloya.Ekle( kitap );
            ///////////////////////////////////////////////////////
            
            
        }
    }
}
