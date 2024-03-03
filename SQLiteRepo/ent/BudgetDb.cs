using Core.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
	[Table("Budgets")]
	public class BudgetDb
	{
		public int id {  get; set; }
		public string name { get; set; }
		//IEnumerable<BudgetIncoming>? BudgetIncomings { get; set; }
		public IEnumerable<PaymentDb>? Payments { get; set; }
	}
}
