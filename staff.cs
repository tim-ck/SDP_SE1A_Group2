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
    
    public partial class staff
    {
        public staff()
        {
            this.attendences = new HashSet<attendence>();
            this.staff1 = new HashSet<staff>();
        }
    
        public string staffID { get; set; }
        public string staffPwd { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string staffType { get; set; }
        public string reportsTo { get; set; }
        public float salary { get; set; }
    
        public virtual ICollection<attendence> attendences { get; set; }
        public virtual ICollection<staff> staff1 { get; set; }
        public virtual staff staff2 { get; set; }
    }
}
