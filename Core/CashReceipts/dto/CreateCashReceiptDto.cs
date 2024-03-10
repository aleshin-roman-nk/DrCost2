using Core.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CashReceipts.dto
{
	public class CreateCashReceiptDto
	{
		public string name {  get; set; } = string.Empty;
		public DateTime Date { get; set; }
		public IEnumerable<CreatePaymentDto> CreatePaymentDtos { get; set; }
	}
}
