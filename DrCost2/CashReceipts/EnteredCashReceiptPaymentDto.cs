using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.CashReceipts
{
	public class EnteredCashReceiptPaymentDto
	{
		public PaymentSample? paymentSample { get; set; }
		public decimal price { get; set; }
		public decimal count { get; set; }
		public decimal sum => price * count;
		//public DateTime DateTime { get; set; }
		public int budgetId { get; set; }
		public string? name => paymentSample == null ? string.Empty : paymentSample.name;
		public string? category => paymentSample == null ? string.Empty : paymentSample.category.name;
		public string budgetName { get; set; }
	}
}
