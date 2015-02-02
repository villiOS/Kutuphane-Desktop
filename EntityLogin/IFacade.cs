using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLogin
{
    interface IFacade
    {
        void Ekle( object processObject );
        void Sil( object processObject );
        void Güncelle( object processObject );
    }
}
