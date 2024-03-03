﻿using Core.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views
{
	public interface ICreateBudgetView
	{
		void ShowModal();
		event EventHandler<CreateBudgetDto> Completed;
	}
}
