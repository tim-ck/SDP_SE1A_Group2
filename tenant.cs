//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP_SE1A_Group2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tenant
    {
        public tenant()
        {
            this.item = new HashSet<item>();
            this.rentinfo = new HashSet<rentinfo>();
        }
    
        public string tenantID { get; set; }
        public string tenantName { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<item> item { get; set; }
        public virtual ICollection<rentinfo> rentinfo { get; set; }
    }
}
