using EntityLogin;
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
    public partial class frmOduncRapor : Form
    {
        public frmOduncRapor( )
        {
            InitializeComponent();
        }
        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void btnOduncRaporKapat_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmOduncRapor_Load( object sender, EventArgs e )
        {
            var oduncListesi = ( DB.Odunc.Select( x => new
            {
                x.Kitaplar.kitapAdi,
                x.Kitaplar.yazari,
                x.Ogrenciler.ogrenciNo,
                x.Ogrenciler.ogrenciAd,
                x.Ogrenciler.ogrenciSoyad,
                x.oduncTarih,
                x.teslimTarih,
                x.oduncDurum
            } ) ).ToList();

            dgridOduncTablo.DataSource = oduncListesi;

            dgridOduncTablo.Columns[0].HeaderText = "Kitap Adı";

            dgridOduncTablo.Columns[1].HeaderText = "Yazarı";

            dgridOduncTablo.Columns[2].HeaderText = "Öğrenci No";

            dgridOduncTablo.Columns[3].HeaderText = "Öğrenci Ad";

            dgridOduncTablo.Columns[4].HeaderText = "Öğrenci Soyad";

            dgridOduncTablo.Columns[5].HeaderText = "Ödünç Alınma";

            dgridOduncTablo.Columns[6].HeaderText = "Teslim Edilme";

            dgridOduncTablo.Columns[7].HeaderText = "Kitap Öğrencide";

            


        }

        

        private void btnOgrenciyeGoreSorgula_Click( object sender, EventArgs e )
        {
            dgridOduncTablo.DataSource = null;
            
            var ogrenciyeGoreOduncler_ = (
                DB.Odunc.Where(
                    x => x.Ogrenciler.ogrenciNo.Contains( txtOgrenciNo.Text ) &&
                         x.Ogrenciler.ogrenciAd.Contains( txtOgrenciAdi.Text ) &&
                         x.Ogrenciler.ogrenciSoyad.Contains( txtOgrenciSoyadi.Text ) &&
                         x.Ogrenciler.cepTelefon.Contains( txtCepTelefonu.Text ) &&
                         x.Ogrenciler.Bolum.bolumAd.Contains( txtBolum.Text ) &&
                         x.Ogrenciler.Bolum.Fakulte.fakulteAd.Contains( txtFakulte.Text )
                ) ).ToList();

            var ogrenciyeGoreOduncler = ( ogrenciyeGoreOduncler_.Select( x => new
            {

                x.Kitaplar.kitapAdi,
                x.Kitaplar.yazari,
                x.Ogrenciler.ogrenciNo,
                x.Ogrenciler.ogrenciAd,
                x.Ogrenciler.ogrenciSoyad,
                x.oduncTarih,
                x.teslimTarih,
                x.oduncDurum,
                x.Kitaplar.kitapKodu,
                x.Kitaplar.kategori,
                x.Kitaplar.ISBN
                
                
            } ) ).ToList();

            dgridOduncTablo.DataSource = ogrenciyeGoreOduncler; //colum o hedır text


            dgridOduncTablo.Columns[0].HeaderText = "Kitap Adı:";

            dgridOduncTablo.Columns[1].HeaderText = "Yazarı";

            dgridOduncTablo.Columns[2].HeaderText = "Öğrenci No";

            dgridOduncTablo.Columns[3].HeaderText = "Öğrenci Ad";

            dgridOduncTablo.Columns[4].HeaderText = "Öğrenci Soyad";

            dgridOduncTablo.Columns[5].HeaderText = "Ödünç Alınma";

            dgridOduncTablo.Columns[6].HeaderText = "Teslim Edilme";

            dgridOduncTablo.Columns[7].HeaderText = "Kitap Öğrencide";

            dgridOduncTablo.Columns[8].HeaderText = "Kitap Kodu";

            dgridOduncTablo.Columns[9].HeaderText = "Kategori";

            dgridOduncTablo.Columns[10].HeaderText = "ISBN";
            
        }

        private void btnKitabaGoreSorgula_Click( object sender, EventArgs e )
        {
            dgridOduncTablo.DataSource = null;

            var kitabaGoreOduncler_ = (
                DB.Odunc.Where(
                    x => x.Kitaplar.kitapKodu.Contains( txtKitapKodu.Text ) &&
                         x.Kitaplar.kitapAdi.Contains( txtKitapAdi.Text ) &&
                         x.Kitaplar.yazari.Contains( txtKitapYazari.Text ) &&
                         x.Kitaplar.ISBN.Contains( txtISBN.Text )
                ) ).ToList();

            var kitabaGoreOduncler = ( kitabaGoreOduncler_.Select( x => new
            {

                x.Kitaplar.kitapAdi,
                x.Kitaplar.yazari,
                x.Ogrenciler.ogrenciNo,
                x.Ogrenciler.ogrenciAd,
                x.Ogrenciler.ogrenciSoyad,
                x.oduncTarih,
                x.teslimTarih,
                x.oduncDurum,
                x.Kitaplar.kitapKodu,
                x.Kitaplar.kategori,
                x.Kitaplar.ISBN


            } ) ).ToList();

            dgridOduncTablo.DataSource = kitabaGoreOduncler; //colum o hedır text


            dgridOduncTablo.Columns[0].HeaderText = "Kitap Adı:";

            dgridOduncTablo.Columns[1].HeaderText = "Yazarı";

            dgridOduncTablo.Columns[2].HeaderText = "Öğrenci No";

            dgridOduncTablo.Columns[3].HeaderText = "Öğrenci Ad";

            dgridOduncTablo.Columns[4].HeaderText = "Öğrenci Soyad";

            dgridOduncTablo.Columns[5].HeaderText = "Ödünç Alınma";

            dgridOduncTablo.Columns[6].HeaderText = "Teslim Edilme";

            dgridOduncTablo.Columns[7].HeaderText = "Kitap Öğrencide";

            dgridOduncTablo.Columns[8].HeaderText = "Kitap Kodu";

            dgridOduncTablo.Columns[9].HeaderText = "Kategori";

            dgridOduncTablo.Columns[10].HeaderText = "ISBN";
        }
    }
}
