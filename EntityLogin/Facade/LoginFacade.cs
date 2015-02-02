using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLogin.Facade
{
    public class LoginFacade
    {
        public bool Kontrol( string adminName, string adminPass )
        {
            var db = new KutuphaneDBEntities();

            var admin = from x in db.Admin
                        where x.adminName == adminName && x.adminPassword == adminPass
                        select x;

            foreach ( var item in admin )
            {
                if ( item.adminName == adminName && item.adminPassword == adminPass )
                    return true;
                else
                    return false;
                
            }
            return false;
            
        }

        //public void Ekle(Admin admin )
        //{
        //    using ( var db =new KutuphaneDBEntities() )
        //    {
        //        db.Admin.Add( admin );
        //        db.SaveChanges();
        //    }
        //}

    }
}
