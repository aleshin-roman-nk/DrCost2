using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
    public class ProductName
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int ProductCategoryId { get; set; }
        public int findingTagId { get; set; }
//        public ProductCategory category { get; set; }
    }
}
