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
    
    public partial class suborder
    {
        public string orderID { get; set; }
        public string suborderID { get; set; }
        public string itemID { get; set; }
        public string qty { get; set; }
    
        public virtual item item { get; set; }
        public virtual order order { get; set; }
    }
}
