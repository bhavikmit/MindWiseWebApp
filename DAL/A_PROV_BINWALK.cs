//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class A_PROV_BINWALK
    {
        public string BIN { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string ClientName { get; set; }
    
        public virtual A_PROV_CLIENT A_PROV_CLIENT { get; set; }
    }
}
