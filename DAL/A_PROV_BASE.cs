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
    
    public partial class A_PROV_BASE
    {
        public int id { get; set; }
        public Nullable<int> BASE_ID { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string BaseInfo { get; set; }
        public string BaseDate { get; set; }
        public System.DateTime DateAdded { get; set; }
    
        public virtual A_PROV_SRC A_PROV_SRC { get; set; }
    }
}
