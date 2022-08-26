using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLibrary
{
    public enum ProductStatus { Active, Draft }

    public class ProductModel
    {
        public string Name { get; set; }
        public ProductCategoryModel Category { get; set; }
        public ProductStatus Status { get; set; } = ProductStatus.Draft;
        public string Description { get; set; }
        public int ReorderLevel { get; set; }
        public string SKU { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
        public decimal Price { get; set; }
        public List<string> Media { get; set; } = new List<string>();
    }
}
