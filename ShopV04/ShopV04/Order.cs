//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopV04
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int SellerID { get; set; }
        public int ProductID { get; set; }
        public string OrderDate { get; set; }
        public string UserID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
