using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
	public class BudgetTitle
	{
		public int id {  get; set; }
		public string? name { get; set; }
		public decimal paymentTotalOfMonth {  get; set; }
		//public string? year { get; }
		//public string? month { get; }
	}
}
