using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
    public class Payment
    {
		public int id { get; set; }
		public string? name { get; set; }
		public decimal price { get; set; }
		public decimal count { get; set; }
		public DateTime Date { get; set; }
		public decimal sum => price * count;
		public string? categoryName { get; set; }
    }
}
