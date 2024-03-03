using Core.dto;
using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repos
{
	public interface IBudgetRepo
	{
		Budget GetBudget(int budgetId, int year, int month);
		IEnumerable<BudgetTitle> GetBudgets(int year, int month);
		BudgetTitle Create(CreateBudgetDto createBudgetDto);
	}
}
