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
    
    public partial class order_detail
    {
        public string orderID { get; set; }
        public string itemID { get; set; }
        public float unitPrice { get; set; }
        public int qty { get; set; }
        public float totalPrice { get; set; }
    
        public virtual item item { get; set; }
        public virtual order order { get; set; }
    }
}
