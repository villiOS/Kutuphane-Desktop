//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLogin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fakulte
    {
        public Fakulte()
        {
            this.Bolum = new HashSet<Bolum>();
        }
    
        public int id { get; set; }
        public string fakulteAd { get; set; }
    
        public virtual ICollection<Bolum> Bolum { get; set; }
    }
}
