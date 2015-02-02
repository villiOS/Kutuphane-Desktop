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
    public partial class frmOgrenciListesi : Form
    {
        public frmOgrenciListesi( )
        {
            InitializeComponent();
        }
        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void btnOgrenciListesiKapat_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        public void frmOgrenciListesi_Load( object sender, EventArgs e )
        {
            List<Fakulte> list = DB.Fakulte.ToList();
            cboxFakulte.DisplayMember = "fakulteAd";
            cboxFakulte.ValueMember = "id";
            cboxFakulte.DataSource = list;
            cboxFakulte.Invalidate();

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

            dgridOgrenciListesi.DataSource = ogrenciler;
            


        }

        private void dgridOgrenciListesi_RowHeaderMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {




            frmOgrenciGuncelle frmOgrenciGuncelle = new frmOgrenciGuncelle();
            
            frmOgrenciGuncelle.txtOgrenciNo.Text = dgridOgrenciListesi.CurrentRow.Cells["ogrenciNo"].Value.ToString();
            frmOgrenciGuncelle.txtOgrenciAd.Text = dgridOgrenciListesi.CurrentRow.Cells["ogrenciAd"].Value.ToString();
            frmOgrenciGuncelle.txtOgrenciSoyad.Text = dgridOgrenciListesi.CurrentRow.Cells["ogrenciSoyad"].Value.ToString();
            frmOgrenciGuncelle.txtAdres.Text = dgridOgrenciListesi.CurrentRow.Cells["adres"].Value.ToString();
            frmOgrenciGuncelle.txtMemleketAdres.Text = dgridOgrenciListesi.CurrentRow.Cells["memleketAdres"].Value.ToString();
            frmOgrenciGuncelle.txtCepTelefonu.Text = dgridOgrenciListesi.CurrentRow.Cells["cepTelefon"].Value.ToString();

            frmOgrenciGuncelle.ShowDialog();
            
            

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

        private void btnFakulteBolumAra_Click( object sender, EventArgs e )
        {
            //btnOgrenciAra.Enabled = true;
            //var bulunanKayitlar = ( from kayit in DB.Ogrenciler
            //                        where kayit.Bolum.bolumAd == cboxBolum.Text && kayit.Bolum.Fakulte.fakulteAd == cboxFakulte.Text
            //                        select kayit ).ToList();
            try
            {
                var bulunanKayitlar_ = ( DB.Ogrenciler.Where( x => x.Bolum.bolumAd == cboxBolum.Text && x.Bolum.Fakulte.fakulteAd == cboxFakulte.Text ) ).ToList();

                var bulunanKayitlar = ( bulunanKayitlar_.Select( x => new
                {
                    x.ogrenciNo,
                    x.ogrenciAd,
                    x.ogrenciSoyad,
                    x.Bolum.Fakulte.fakulteAd,
                    x.Bolum.bolumAd,
                    x.kayitTarih,
                    x.adres,
                    x.memleketAdres,
                    x.cepTelefon
                } ) ).ToList();


                dgridAramaSonuclar.DataSource = bulunanKayitlar;


                dgridAramaSonuclar.Columns[0].HeaderText = "Öğrenci No";
                dgridAramaSonuclar.Columns[1].HeaderText = "Öğrenci Adı";
                dgridAramaSonuclar.Columns[2].HeaderText = "Öğrenci Soyadı";
                dgridAramaSonuclar.Columns[3].HeaderText = "Fakülte";
                dgridAramaSonuclar.Columns[4].HeaderText = "Bölüm";
                dgridAramaSonuclar.Columns[5].HeaderText = "Kayıt Tarihi";
                dgridAramaSonuclar.Columns[6].HeaderText = "Adres";
                dgridAramaSonuclar.Columns[7].HeaderText = "Memleket Adresi";
                dgridAramaSonuclar.Columns[8].HeaderText = "Cep Telefonu";
            }
            catch ( Exception exMessage )
            {
                MessageBox.Show("" + exMessage.ToString() );
            }
            finally
            {
                if ( dgridAramaSonuclar.RowCount == 0 )
                {
                    //btnOgrenciAra.Enabled = false;
                    dgridAramaSonuclar.DataSource = null;
                    MessageBox.Show( "Aradığınız Kritelere Göre Kayıt Bulunamadı !" ,"Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }    
            }


        }

        private void btnOgrenciAra_Click( object sender, EventArgs e )
        {
            var bulunanKayitlar_ = ( 
                DB.Ogrenciler.Where( 
                    x => x.ogrenciNo.Contains( txtOgrenciNo.Text ) && 
                         x.ogrenciAd.Contains( txtOgrenciAd.Text ) && 
                         x.ogrenciSoyad.Contains( txtOgrenciSoyad.Text ) && 
                         x.cepTelefon.Contains( txtCepTelefon.Text ) ) ).ToList();

            var bulunanKayitlar = ( bulunanKayitlar_.Select( x => new
            {
                x.ogrenciNo,
                x.ogrenciAd,
                x.ogrenciSoyad,
                x.Bolum.Fakulte.fakulteAd,
                x.Bolum.bolumAd,
                x.kayitTarih,
                x.adres,
                x.memleketAdres,
                x.cepTelefon
            } ) ).ToList();

            dgridAramaSonuclar.DataSource = bulunanKayitlar;

            dgridAramaSonuclar.Columns[0].HeaderText = "Öğrenci No";
            dgridAramaSonuclar.Columns[1].HeaderText = "Öğrenci Adı";
            dgridAramaSonuclar.Columns[2].HeaderText = "Öğrenci Soyadı";
            dgridAramaSonuclar.Columns[3].HeaderText = "Fakülte";
            dgridAramaSonuclar.Columns[4].HeaderText = "Bölüm";
            dgridAramaSonuclar.Columns[5].HeaderText = "Kayıt Tarihi";
            dgridAramaSonuclar.Columns[6].HeaderText = "Adres";
            dgridAramaSonuclar.Columns[7].HeaderText = "Memleket Adresi";
            dgridAramaSonuclar.Columns[8].HeaderText = "Cep Telefonu";

        }

        private void txtOgrenciNo_TextChanged( object sender, EventArgs e )
        {

        }

        private void txtOgrenciAd_TextChanged( object sender, EventArgs e )
        {

        }

        private void txtOgrenciSoyad_TextChanged( object sender, EventArgs e )
        {

        }

        private void txtCepTelefon_TextChanged( object sender, EventArgs e )
        {

        }

        
    }
}
