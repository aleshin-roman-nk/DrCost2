using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
	public class Budget
	{
		public int id {  get; set; }
		public string? name { get; set; }
		public IEnumerable<BudgetIncoming>? BudgetIncomings {  get; set; }
		public IEnumerable<Payment>? Payments { get; set; }
		//public string? year { get; }
		//public string? month { get; }
	}
}