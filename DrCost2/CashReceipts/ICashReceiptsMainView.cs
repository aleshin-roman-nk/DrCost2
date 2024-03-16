using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.CashReceipts
{
	public interface ICashReceiptsMainView
	{
		void ShowModal();
		event EventHandler PaymentsChanged;
	}
}
