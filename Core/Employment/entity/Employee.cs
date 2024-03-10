using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.entity
{
	public class Employee
	{
		public int id {  get; set; }
		public int employeeSourceId { get; set; }
		public int payDocId { get; set; }
		public string? name { get; set; }
		public IEnumerable<EmplPayment>? Payments { get; set; } = new List<EmplPayment>();
		public bool cash { get; set; }
		public decimal sum => Payments == null ? 0 : Payments.Sum(x => x.sum);
	}
}
