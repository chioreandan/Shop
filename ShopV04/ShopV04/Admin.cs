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
    
    public partial class Admin
    {
        public int Userid { get; set; }
        public int AdminID { get; set; }
        public Nullable<int> SellerID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    
        public virtual user user { get; set; }
    }
}
