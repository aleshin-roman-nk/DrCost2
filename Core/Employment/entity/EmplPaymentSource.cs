using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.entity
{
	public class EmplPaymentSource
	{
		public int id {  get; set; }
		public int tagId { get; set; }
		public string? tagName => emplPaymentTag.name;
		public EmplPaymentTag? emplPaymentTag { get; set; }
		public string? name { get; set; }
		public decimal price { get; set; }
	}
}
