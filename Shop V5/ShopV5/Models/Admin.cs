namespace ShopV5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int UserId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }

        public int? SellersID { get; set; }

        public int? SupplierID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(16)]
        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
