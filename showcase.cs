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
    
    public partial class showcase
    {
        public showcase()
        {
            this.rentinfo = new HashSet<rentinfo>();
            this.reservation = new HashSet<reservation>();
            this.showcaseitem = new HashSet<showcaseitem>();
        }
    
        public string showcaseid { get; set; }
        public int size { get; set; }
        public float rental { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<rentinfo> rentinfo { get; set; }
        public virtual ICollection<reservation> reservation { get; set; }
        public virtual ICollection<showcaseitem> showcaseitem { get; set; }
    }
}
