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
    public partial class frmOdunc : Form
    {
        public frmOdunc( )
        {
            InitializeComponent();
        }

        KutuphaneDBEntities DB = new KutuphaneDBEntities();
        private void btnOduncIptal_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnOgrenciAra_Click( object sender, EventArgs e )
        {
            
            bool findSuccess = false;
            
            var ogrenciNumaralar = from no in DB.Ogrenciler
                    where no.ogrenciNo == txtOgrenciNumaraAra.Text
                    select no;



            foreach ( var bulunan in ogrenciNumaralar )
            {
                //MessageBox.Show( item.ogrenciNo );
                findSuccess = true;
                txtOduncBilgi.Text = bulunan.ogrenciAd + " " + bulunan.ogrenciSoyad;
                txtKitapAra.Enabled = true;
                btnOduncBilgiSorgula.Enabled = true;
            }

            if ( findSuccess == false )
            {
                txtKitapAra.Enabled = false;
                btnOduncBilgiSorgula.Enabled = false;
                MessageBox.Show( "Aradığınız Kayıt Bulunamadı ! \n Öğrenci numarasını doğru girdiğinizden emin olunuz !", "Arama Sonucu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                txtKitapAra.Text = "";
                txtOduncBilgi.Text = "";
                txtOgrenciNumaraAra.Text = "";
            }

           

            

        }


        private void btnKitapAra_Click( object sender, EventArgs e )
        {
            bool findSuccess = false;
            
            var kitapAdlar = from ad in DB.Kitaplar
                             where ad.kitapAdi == txtKitapAra.Text
                             select ad;

            foreach ( var bulunan in kitapAdlar )
            {
                findSuccess = true;
                txtOduncBilgi.Text += " --> " + bulunan.kitapAdi + " (" + bulunan.yazari + ")";
                btnOduncOnay.Enabled = true;
            }

            if ( findSuccess == false )
            {
                MessageBox.Show( "Aradığınız Kayıt Bulunamadı ! \n Kitap adını doğru girdiğinizden emin olunuz !", "Arama Sonucu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning );
  
            }


        }

        private void btnOduncOnay_Click( object sender, EventArgs e )
        {

            btnOduncOnay.Enabled = false;
            Odunc odunc = new Odunc();
            //////////////////////////////////////////////////
            var kitapId = from id in DB.Kitaplar
                        where id.kitapAdi == txtKitapAra.Text
                        select id;

            foreach ( var id in kitapId )
            {
                odunc.kitapId = id.id;
                break;
            }
            //////////////////////////////////////////////////
            var ogrenciId = from id in DB.Ogrenciler
                            where id.ogrenciNo == txtOgrenciNumaraAra.Text
                            select id;

            foreach ( var id in ogrenciId )
            {
                odunc.ogrenciId = id.id;
                break;
            }
            //////////////////////////////////////////////////
            odunc.oduncTarih = DateTime.Now;
            odunc.oduncDurum = true;
            odunc.teslimTarih = DateTime.Now;
            
            

            //Ödünç Verilecek Kitabın Durum Kontrolü
            bool kayitSuccess = OduncKitapKontrol(odunc);
            ///////////////////////////////////////////////////

            if(kayitSuccess)
            {
                //Ödünç Kitap Verilerinin DB'ye kayıt edilmesi
                OduncFacade oduncAlmaBilgisi = new OduncFacade();
                oduncAlmaBilgisi.Ekle( odunc );
                ///////////////////////////////////////////////////
            }
            else
            {
                MessageBox.Show( "Ödünç Onayı Başarısız ! \n Bu kitap bir başkası tarafından ödünç alınmıştır !", "Ödünç Durumu", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            
        }

        private bool OduncKitapKontrol( Odunc odunc )
        {
            var kontrolListe = from kontrol in DB.Odunc
                               where odunc.kitapId == kontrol.kitapId
                               select kontrol;

            foreach ( var item in kontrolListe )
            {
                return false;
            }

            return true;
        }


       

        private void btnOduncBilgiSorgula_Click( object sender, EventArgs e )
        {
            btnOduncBilgiSorgula.Enabled = false;
            OduncBilgisiGoster();
        }

        private void OduncBilgisiGoster( )
        {
            //List<Odunc> odunc = new List<Odunc>();
            var odunc = (DB.Odunc.Select( x => new
            {
                x.Kitaplar.kitapAdi,
                x.Ogrenciler.ogrenciNo,
                x.Ogrenciler.ogrenciAd,
                x.Ogrenciler.ogrenciSoyad,
                x.oduncTarih,
                x.teslimTarih,
                x.oduncDurum
            } )).ToList();


            foreach ( var item in odunc )
            {
                if ( item.ogrenciNo == txtOgrenciNumaraAra.Text )
                {
                    dgridOduncBilgisi.DataSource = odunc;

                    dgridOduncBilgisi.Columns[0].HeaderText = "Kitap Adı";
                    dgridOduncBilgisi.Columns[1].HeaderText = "Öğrenci No";
                    dgridOduncBilgisi.Columns[2].HeaderText = "Öğrenci Adı";
                    dgridOduncBilgisi.Columns[3].HeaderText = "Öğrenci Soyadı";
                    dgridOduncBilgisi.Columns[4].HeaderText = "Ödünç Aldığı Tarih";
                    dgridOduncBilgisi.Columns[5].HeaderText = "Teslim Ettiği Tarih";
                    dgridOduncBilgisi.Columns[6].HeaderText = "Ödünç Durumu";
                }
                else
                {
                    dgridOduncBilgisi.DataSource = null;
                    MessageBox.Show( "Ödünç Alınan Herhangi Bir Kitap Bulunamadı","Ödünç Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
                
            }
                
           

            

            

        }

        private void frmOdunc_Load( object sender, EventArgs e )
        {

        }

        private void groupBox1_Enter( object sender, EventArgs e )
        {

        }


    }
}
