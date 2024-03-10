using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment.ent
{
	[Table("EmplPayments")]
	public class EmplPaymentDb
	{
		public int id { get; set; }
		public int employeeId { get; set; }
		public int emplPaymentSourceId {  get; set; }
		public string? description { get; set; }
		public int tagId { get; set; }
		public EmplPaymentTag? EmplPaymentTag { get; set; }
		public decimal price { get; set; }
		public decimal amount { get; set; }
		public string? name { get; set; }
		public bool completed { get; set; } = false;
	}
}
