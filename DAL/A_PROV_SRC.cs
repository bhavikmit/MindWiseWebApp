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
    
    public partial class A_PROV_SRC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public A_PROV_SRC()
        {
            this.A_PROV_CVV_LDG = new HashSet<A_PROV_CVV_LDG>();
            this.A_PROV_CVV_PR = new HashSet<A_PROV_CVV_PR>();
            this.A_PROV_DUMPS_LDG = new HashSet<A_PROV_DUMPS_LDG>();
            this.A_PROV_DUMPS_PR = new HashSet<A_PROV_DUMPS_PR>();
            this.LDGColumnMappings = new HashSet<LDGColumnMapping>();
        }
    
        public int SrcID { get; set; }
        public string SrcName { get; set; }
        public string SrcURL { get; set; }
        public string SrcAltURL { get; set; }
        public string SrcMetadata { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<A_PROV_CVV_LDG> A_PROV_CVV_LDG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<A_PROV_CVV_PR> A_PROV_CVV_PR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<A_PROV_DUMPS_LDG> A_PROV_DUMPS_LDG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<A_PROV_DUMPS_PR> A_PROV_DUMPS_PR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LDGColumnMapping> LDGColumnMappings { get; set; }
    }
}
