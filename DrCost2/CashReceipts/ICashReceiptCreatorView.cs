using Core.CashReceipts.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.CashReceipts
{
	public interface ICashReceiptCreatorView
	{
		void ShowModel();
		event EventHandler<CreateCashReceiptDto> Completed;
	}
}
