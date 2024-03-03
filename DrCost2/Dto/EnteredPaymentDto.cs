using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.Dto
{
    public class EnteredPaymentDto
	{
		public PaymentSample? paymentSample { get; set; }
		public decimal price { get; set; }
		public decimal count { get; set; }
		public DateTime DateTime { get; set; }
		public string? name => paymentSample.name;
		public string? category => paymentSample.category.name;
	}
}
