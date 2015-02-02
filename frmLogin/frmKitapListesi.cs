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
    public partial class frmKitapListesi : Form
    {
        public frmKitapListesi( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void frmKitapListesi_Load( object sender, EventArgs e )
        {
            var kitaplar = ( DB.Kitaplar.Select( x => new
                {
                    x.kitapKodu,
                    x.kitapAdi,
                    x.kategori,
                    x.yayinYili,
                    x.yazari,
                    x.ISBN,
                    x.sayfaSayisi
                } ) ).ToList();


            dgridKitapListesi.DataSource = kitaplar;

            dgridKitapListesi.Columns[0].HeaderText = "Kitap Kodu";
            dgridKitapListesi.Columns[1].HeaderText = "Kitap Adı";
            dgridKitapListesi.Columns[2].HeaderText = "Kategori";
            dgridKitapListesi.Columns[3].HeaderText = "Yayın Yılı";
            dgridKitapListesi.Columns[4].HeaderText = "Yazarı";
            dgridKitapListesi.Columns[5].HeaderText = "ISBN";
            dgridKitapListesi.Columns[6].HeaderText = "Sayfa Sayısı";
        }

        private void dgridKitapListesi_RowHeaderMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            frmKitapGuncelle frmKitapGuncelle = new frmKitapGuncelle();

            frmKitapGuncelle.txtKitapKodu.Text = dgridKitapListesi.CurrentRow.Cells["kitapKodu"].Value.ToString();
            frmKitapGuncelle.txtKitapAdi.Text = dgridKitapListesi.CurrentRow.Cells["kitapAdi"].Value.ToString();
            frmKitapGuncelle.txtKitapKategori.Text = dgridKitapListesi.CurrentRow.Cells["kategori"].Value.ToString();
            frmKitapGuncelle.dpicYayinYili.Text = dgridKitapListesi.CurrentRow.Cells["yayinYili"].Value.ToString();
            frmKitapGuncelle.txtYazar.Text = dgridKitapListesi.CurrentRow.Cells["yazari"].Value.ToString();
            frmKitapGuncelle.txtISBN.Text = dgridKitapListesi.CurrentRow.Cells
              ["ISBN"].Value.ToString();
            frmKitapGuncelle.txtSayfaSayisi.Text = dgridKitapListesi.CurrentRow.Cells["sayfaSayisi"].Value.ToString();





            frmKitapGuncelle.ShowDialog();
        }

        private void btnKitapListesiKapat_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void cxboxGelismisArama_CheckedChanged( object sender, EventArgs e )
        {
            if ( cxboxGelismisArama.Checked == true )
            {
                gboxGelismisArama.Enabled = true;
                gboxBasitArama.Enabled = false;
                cxboxBasitArama.Checked = false;

            }
            else
            {
                gboxGelismisArama.Enabled = false;
                gboxBasitArama.Enabled = true;
            }
        }

        private void cxboxBasitArama_CheckedChanged( object sender, EventArgs e )
        {
            if ( cxboxBasitArama.Checked == true )
            {
                gboxBasitArama.Enabled = true;
                gboxGelismisArama.Enabled = false;
                cxboxGelismisArama.Checked = false;
            }
            else
            {
                gboxBasitArama.Enabled = false;
                gboxGelismisArama.Enabled = true;
            }
        }

        private void btnKitapAra_Click( object sender, EventArgs e )
        {
            var bulunanKayitlar_ = (
                DB.Kitaplar.Where(
                    x => x.kitapKodu.Contains( txtKitapKodu.Text ) &&
                         x.kitapAdi.Contains( txtKitapAdi.Text ) &&
                         x.kategori.Contains( txtKitapKategori.Text ) &&
                         x.yazari.Contains( txtKitapYazari.Text )
                        ) ).ToList();

            var bulunanKayitlar = ( bulunanKayitlar_.Select( x => new
            {
                x.kitapKodu,
                x.kitapAdi,
                x.kategori,
                x.yayinYili,
                x.yazari,
                x.ISBN,
                x.sayfaSayisi
            } ) ).ToList();


            dgridBulunanKitaplar.DataSource = bulunanKayitlar;

            dgridBulunanKitaplar.Columns[0].HeaderText = "Kitap Kodu";
            dgridBulunanKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgridBulunanKitaplar.Columns[2].HeaderText = "Kategori";
            dgridBulunanKitaplar.Columns[3].HeaderText = "Yayın Yılı";
            dgridBulunanKitaplar.Columns[4].HeaderText = "Yazarı";
            dgridBulunanKitaplar.Columns[5].HeaderText = "ISBN";
            dgridBulunanKitaplar.Columns[6].HeaderText = "Sayfa Sayısı";


        }

        private void dgridBulunanKitaplar_RowHeaderMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            frmBulunanKitapGuncelleme frmBulunanKitapGuncelleme = new frmBulunanKitapGuncelleme();

           

            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapKodu.Text = dgridBulunanKitaplar.CurrentRow.Cells["kitapKodu"].Value.ToString();
            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapAdi.Text = dgridBulunanKitaplar.CurrentRow.Cells["kitapAdi"].Value.ToString();
            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapKategori.Text = dgridBulunanKitaplar.CurrentRow.Cells["kategori"].Value.ToString();
            frmBulunanKitapGuncelleme.dpicBulunanGuncellenecekKitapYayınYili.Text = dgridBulunanKitaplar.CurrentRow.Cells["yayinYili"].Value.ToString();
            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapYazari.Text = dgridBulunanKitaplar.CurrentRow.Cells["yazari"].Value.ToString();
            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapISBN.Text = dgridBulunanKitaplar.CurrentRow.Cells["ISBN"].Value.ToString();
            frmBulunanKitapGuncelleme.txtBulunanGuncellenecekKitapSayfaSayisi.Text = dgridBulunanKitaplar.CurrentRow.Cells["sayfaSayisi"].Value.ToString();




            frmBulunanKitapGuncelleme.ShowDialog();
        }
    }
}
