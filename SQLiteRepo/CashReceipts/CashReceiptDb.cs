using Core.entity;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.CashReceipts
{
	public class CashReceiptDb
	{
		public int id { get; set; }
		public string shop { get; set; } = string.Empty;
		public DateTime Date { get; set; }
		public ICollection<PaymentDb> Payments { get; set; } = new List<PaymentDb>();
	}
}
