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
    
    public partial class store
    {
        public store()
        {
            this.orders = new HashSet<order>();
            this.rentinfoes = new HashSet<rentinfo>();
            this.showcaseitems = new HashSet<showcaseitem>();
        }
    
        public string storeID { get; set; }
        public string storeAddress { get; set; }
    
        public virtual ICollection<order> orders { get; set; }
        public virtual ICollection<rentinfo> rentinfoes { get; set; }
        public virtual ICollection<showcaseitem> showcaseitems { get; set; }
    }
}
