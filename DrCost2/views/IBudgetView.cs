﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views
{
	public interface IBudgetView
	{
		void ShowModal(int budgetId);
		event EventHandler BudgetStateChange;
	}
}
