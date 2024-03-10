using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
	public class CreatePaymentDto
	{
		public string? name { get; set; }
		public decimal price { get; set; }
		public decimal count { get; set; }
		public DateTime Date { get; set; }
		public int categoryId { get; set; }
		public int budgetId { get; set; }
		public int paymentSampleId { get; set; }
		public int? cashReceiptId { get; set; }
	}
}
