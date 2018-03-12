using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int ProductCategoryForeignKey { get; set; }
        
    }
}
