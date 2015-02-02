using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLogin.Facade
{
    public class KitapFacade
    {

        public void Ekle( Kitaplar kitap )
        {
            using ( var db = new KutuphaneDBEntities() )
            {
                try
                {
                    db.Kitaplar.Add( kitap );
                    db.SaveChanges();
                    KayitMesaj();
                }
                catch ( Exception ex )
                {
                    System.Windows.Forms.MessageBox.Show( ex.Message );
                }
                
            }

        }

        private void KayitMesaj( )
        {
            global::System.Windows.Forms.MessageBox.Show( "Kayıt Eklendi", "Kayıt", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information );
        }
        //public void Sil( int id )
        //{
        //    using ( var db = new KutuphaneDBEntities() )
        //    {
        //        var data = db.Kitaplar.Find( id );
        //        db.Kitaplar.Remove( data );
        //        db.SaveChanges();
        //    }
        //}

    }
}
