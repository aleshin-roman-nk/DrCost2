using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.entity
{
	public class EmplPayment
	{
		public int id {  get; set; }
		public int employeeId { get; set; }
		public int tagId { get; set; }
		public string? tagName { get; set; }
		public decimal price { get; set; }
		public decimal amount { get; set; }
		public string? name { get; set; }
		public decimal sum => price * amount;
		public int emplPaymentSourceId { get; set; }
		public string? description { get; set; }
		public bool completed {  get; set; } = false; 
	}
}
