using Core.dto;
using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class BudgetService
	{
		private readonly IBudgetRepo budgetRepo;

		public BudgetService(IBudgetRepo budgetRepo)
		{
			this.budgetRepo = budgetRepo;
		}

		public Budget GetBudget(int budgetId, int year, int month)
		{
			return this.budgetRepo.GetBudget(budgetId, year, month);
		}
		public IEnumerable<BudgetTitle> GetBudgets(int year, int month)
		{
			return budgetRepo.GetBudgets(year, month);
		}
		public BudgetTitle CreateBudget(CreateBudgetDto createBudgetDto)
		{
			return budgetRepo.Create(createBudgetDto);
		}
	}
}
