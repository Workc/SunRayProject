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
    
    public partial class SalesInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesInvoice()
        {
            this.RequestCycles = new HashSet<RequestCycle>();
            this.SalesInvoiceDetails = new HashSet<SalesInvoiceDetail>();
        }
    
        public long InvoiceId { get; set; }
        public decimal TotalProduct { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalNet { get; set; }
        public Nullable<decimal> TotalRemain { get; set; }
        public System.DateTime Last_Modified_Date { get; set; }
        public System.DateTime Create_Date { get; set; }
        public int IsDeleted { get; set; }
        public long Last_Modified_User { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestCycle> RequestCycles { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesInvoiceDetail> SalesInvoiceDetails { get; set; }
    }
}