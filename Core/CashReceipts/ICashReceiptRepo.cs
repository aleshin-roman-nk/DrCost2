using Core.CashReceipts.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CashReceipts
{
	public interface ICashReceiptRepo
	{
		IEnumerable<CashReceipt> GetAll();
		CashReceipt Create(CreateCashReceiptDto dto);
	}
}
