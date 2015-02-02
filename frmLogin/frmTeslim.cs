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
    public partial class frmTeslim : Form
    {
        public frmTeslim( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void btnOgrenciAra_Click( object sender, EventArgs e )
        {
            bool findSuccess = false;

            var ogrenciNumaralar = from no in DB.Ogrenciler
                                   where no.ogrenciNo == txtOgrenciAdi.Text
                                   select no;

            foreach ( var bulunan in ogrenciNumaralar )
            {
                findSuccess = true;
                var odunc = ( DB.Odunc.Select( x => new
                {
                    x.Kitaplar.kitapAdi,
                    x.Ogrenciler.ogrenciAd,
                    x.Ogrenciler.ogrenciSoyad,
                    x.oduncTarih,
                } ) ).ToList(); //odunc durumu false olanları alma
                
                
                dgridKitapTeslim.DataSource = odunc;
                break;
            }
                
            
            if ( findSuccess == false )
            {
                
                MessageBox.Show( "Aradığınız Kayıt Bulunamadı ! \n Öğrenci numarasını doğru girdiğinizden emin olunuz !", "Arama Sonucu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                dgridKitapTeslim.DataSource = null;
            }
        }

        private void dgridKitapTeslim_RowHeaderMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            
        }

        private void btnKitapTeslimOnay_Click( object sender, EventArgs e )
        {
            //seçili satırdaki kitabın id değerini al.
            //odunç tablosunda eşleşen satırdaki odunç durumu false yap

            //datagridview1.CurrentRow.Cells["HucreAdi"].Value.tostring(); 
            string kitapAdi = dgridKitapTeslim.CurrentRow.Cells["kitapAdi"].Value.ToString();

            var a = ( from b in DB.Odunc
                      where b.Kitaplar.kitapAdi == kitapAdi
                      select b ).ToList();
            
            foreach ( var item in a )
            {
                item.oduncDurum = false;
                TeslimFacade kitapTeslim = new TeslimFacade();
                kitapTeslim.TeslimAl(item.Kitaplar.kitapAdi ,item.oduncDurum, DateTime.Now);
                break;
            }

            

        }

        private void btnTeslimIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
