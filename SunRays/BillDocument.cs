//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunRays
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillDocument
    {
        public long BillDocumentId { get; set; }
        public long Supplier_id { get; set; }
        public string ReasonCatch { get; set; }
        public decimal CatchAmount { get; set; }
        public System.DateTime Last_Modified_Date { get; set; }
        public System.DateTime Create_Date { get; set; }
        public int IsDeleted { get; set; }
        public long Last_Modified_User { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual User User { get; set; }
    }
}