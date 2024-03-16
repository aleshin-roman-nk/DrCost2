using Core.dto;
using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CashReceipts
{
	public class CashReceipt
	{
		public int id {  get; set; }
		public string shop {  get; set; } = string.Empty;
		public DateTime Date { get; set; }
		public IEnumerable<Payment>? Payments { get; set; }
		public string title
		{
			get
			{
				string sum = Payments == null ? string.Empty : $" | {Payments.Sum(x => x.sum).ToString("c")}";
				return $"{Date.ToShortDateString()} | {shop}{sum}";
			}
		}
	}
}
