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
    
    public partial class ProductStore
    {
        public long ProdutStoreId { get; set; }
        public long Product_Id { get; set; }
        public long Store_Id { get; set; }
        public decimal Cost { get; set; }
        public decimal PriceCommercial { get; set; }
        public decimal PriceEnd { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime Last_Modified_Date { get; set; }
        public System.DateTime Create_date { get; set; }
        public int IsDeleted { get; set; }
        public long Last_Modified_User { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}