//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP_SE1A_Group2
{
    using System;
    using System.Collections.Generic;
    
    public partial class employees
    {
        public employees()
        {
            this.customers = new HashSet<customers>();
            this.employees1 = new HashSet<employees>();
        }
    
        public int employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public string officeCode { get; set; }
        public Nullable<int> reportsTo { get; set; }
        public string jobTitle { get; set; }
    
        public virtual ICollection<customers> customers { get; set; }
        public virtual ICollection<employees> employees1 { get; set; }
        public virtual employees employees2 { get; set; }
        public virtual offices offices { get; set; }
    }
}
