namespace ShopV5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrdersID { get; set; }

        public int SellersID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(10)]
        public string OrdersDate { get; set; }

        public int UserId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
