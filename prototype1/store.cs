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
            this.order = new HashSet<order>();
            this.rentinfo = new HashSet<rentinfo>();
            this.showcase = new HashSet<showcase>();
            this.showcaseitem = new HashSet<showcaseitem>();
        }
    
        public string storeID { get; set; }
        public string storeAddress { get; set; }
    
        public virtual ICollection<order> order { get; set; }
        public virtual ICollection<rentinfo> rentinfo { get; set; }
        public virtual ICollection<showcase> showcase { get; set; }
        public virtual ICollection<showcaseitem> showcaseitem { get; set; }
    }
}