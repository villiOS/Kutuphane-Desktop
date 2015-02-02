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
    public partial class frmOgrenciKayit : Form
    {
        public frmOgrenciKayit( )
        {
            InitializeComponent();
            
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void btnOgrenciKayitIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmOgrenciKayit_Load( object sender, EventArgs e )
        {
            List<Fakulte> list = DB.Fakulte.ToList();
            cboxFakulte.DisplayMember = "fakulteAd";
            cboxFakulte.ValueMember = "id";
            cboxFakulte.DataSource = list;
            cboxFakulte.Invalidate();
            
            
            
        }

        private void cboxFakulte_SelectedIndexChanged( object sender, EventArgs e )
        {

            int index = Convert.ToInt32( cboxFakulte.SelectedValue );

            List<Bolum> bolum = DB.Bolum.Where( x => x.fakulteId == index ).ToList();
            
            cboxBolum.DisplayMember = "bolumAd";
            cboxBolum.ValueMember = "id";
            cboxBolum.DataSource = bolum;
            cboxBolum.Invalidate();
                 
        }

        private void btnOgrenciKaydet_Click( object sender, EventArgs e )
        {
            //Öğrenci Bilgilerinin Kullanıcı Arayüzünden Alınması
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.ogrenciNo = txtOgrenciNo.Text;
            ogrenci.ogrenciAd = txtOgrenciAd.Text;
            ogrenci.ogrenciSoyad = txtOgrenciSoyad.Text;
            ogrenci.bolumID = Convert.ToInt32( cboxBolum.SelectedValue );
            ogrenci.adres = txtAdres.Text;
            ogrenci.memleketAdres = txtMemleketAdres.Text;
            ogrenci.kayitTarih = dpicKayitTarih.Value;
            ogrenci.cepTelefon = txtCepTelefon.Text;
            ///////////////////////////////////////////////


            //Bilgilerin DB'ye kayıt edilmesi
            OgrenciFacade ogrencileriTabloya = new OgrenciFacade();
            ogrencileriTabloya.Ekle( ogrenci );
            ////////////////////////////////////////////////

        }

        


    }
}
