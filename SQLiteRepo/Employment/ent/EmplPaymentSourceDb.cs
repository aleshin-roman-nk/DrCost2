using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment.ent
{
	public class EmplPaymentSourceDb
	{
		public int id { get; set; }
		public int tagId { get; set; }
		public EmplPaymentTag? EmplPaymentTag { get; set; }
		public string? name { get; set; }
		public decimal price { get; set; }
	}
}
