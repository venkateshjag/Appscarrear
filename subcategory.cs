//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AICPDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class subcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subcategory()
        {
            this.userdetails = new HashSet<userdetail>();
        }
    
        public int subcategoryid { get; set; }
        public string subcategoryname { get; set; }
        public int categoryid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userdetail> userdetails { get; set; }
    }
}
