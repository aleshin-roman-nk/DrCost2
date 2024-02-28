using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
    public class Product
    {
		public int id { get; set; }
		public int prodNameId { get; set; }
		public int categoryId { get; set; }
		public string? name { get; set; }
		public decimal price { get; set; }
		public decimal count { get; set; }
		public DateTime Date { get; set; }
		public int currencyId { get; set; }
		public string? currencyName { get; set; }
		public decimal sum => price * count;
    }
}
