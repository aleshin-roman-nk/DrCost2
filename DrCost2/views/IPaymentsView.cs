using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views
{
	public interface IPaymentsView
	{
		//void ShowModal(int budgetId, int year, int month, int categoryId = 0);
		void ShowModal(int budgetId);
	}
}
