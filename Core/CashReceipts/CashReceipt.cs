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
		public string name {  get; set; } = string.Empty;
		public DateTime Date { get; set; }
		public IEnumerable<Payment>? Payments { get; set; }
	}
}
