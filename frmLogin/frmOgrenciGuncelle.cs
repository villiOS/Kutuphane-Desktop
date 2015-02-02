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
    public partial class frmOgrenciGuncelle : Form
    {
        public frmOgrenciGuncelle( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();

        Ogrenciler ogrenci = new Ogrenciler();

        private void btnOgrenciKayitIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmOgrenciGuncelle_Load( object sender, EventArgs e )
        {

            
            
            List<Fakulte> list = DB.Fakulte.ToList();
            cboxFakulte.DisplayMember = "fakulteAd";
            cboxFakulte.ValueMember = "id";
            cboxFakulte.DataSource = list;
            cboxFakulte.Invalidate();



            var id = from a in DB.Ogrenciler
                     where a.ogrenciNo == txtOgrenciNo.Text
                     select a.id;

            foreach ( var item in id )
            {
                ogrenci.id = Convert.ToInt32( item );
                break;
            }

            
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

        private void btnOgrenciGuncelle_Click( object sender, EventArgs e )
        {

            //Güncelleme Bilgilerinin Arayüzden Alınması

            
            
            
            ogrenci.ogrenciNo = txtOgrenciNo.Text;
            ogrenci.ogrenciAd = txtOgrenciAd.Text;
            ogrenci.ogrenciSoyad = txtOgrenciSoyad.Text;
            ogrenci.bolumID = Convert.ToInt32( cboxBolum.SelectedValue );
            ogrenci.adres = txtAdres.Text;
            ogrenci.memleketAdres = txtMemleketAdres.Text;
            ogrenci.kayitTarih = DateTime.Now;
            ogrenci.cepTelefon = txtCepTelefonu.Text;

           
            //////////////////////////////////////////////////
            //Güncel Bilgilerin DB'ye Kayıt Edilmesi
            OgrenciGuncelleFacade ogrenciGuncelle = new OgrenciGuncelleFacade();
            ogrenciGuncelle.Guncelle( ogrenci );
            //////////////////////////////////////////////////

            this.Close();
        }

        private void frmOgrenciGuncelle_FormClosed( object sender, FormClosedEventArgs e )
        {
           
            frmOgrenciListesi frmOgrenciListesi = new frmOgrenciListesi();

            var ogrenciler = ( DB.Ogrenciler.Select( x => new
            {
                x.ogrenciNo,
                x.ogrenciAd,
                x.ogrenciSoyad,
                x.Bolum.Fakulte.fakulteAd,
                x.Bolum.bolumAd,
                x.kayitTarih,
                x.memleketAdres,
                x.adres,
                x.cepTelefon
            } ) ).ToList();


            frmOgrenciListesi.dgridOgrenciListesi.DataSource = ogrenciler;
        }

        
    }
}
