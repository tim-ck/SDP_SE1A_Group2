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
    
    public partial class reservation
    {
        public string reservationid { get; set; }
        public string showcaseid { get; set; }
        public string tenantid { get; set; }
    
        public virtual tenant tenant { get; set; }
        public virtual showcase showcase { get; set; }
    }
}
