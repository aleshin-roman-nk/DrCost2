using Core.dto;
using Core.entity;
using Core.repos;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class BudgetsRepo : IBudgetRepo
	{
		private readonly AppData db;

		public BudgetsRepo(AppData db)
		{
			this.db = db;
		}
		public BudgetTitle Create(CreateBudgetDto createBudgetDto)
		{
			BudgetDb b = new BudgetDb { name = createBudgetDto.name};

			db.Budgets.Add(b);

			db.SaveChanges();

			return new BudgetTitle { id = b.id, name = b.name, paymentTotalOfMonth = 0 };
		}

		public Budget GetBudget(int budgetId, int year, int month)
		{
			var b = db.Budgets.FirstOrDefault(x => x.id == budgetId);

			if (b == null) throw new InvalidOperationException($"No budget with id{budgetId}");

			DateTime dt1 = new DateTime(year, month, 1);
			DateTime dt2 = dt1.AddMonths(1);

			var bres = new Budget { id = budgetId, name = b.name };

			bres.Payments = db.Payments
				.Include(x => x.category)
				.Where(p => p.budgetId == budgetId && p.Date >= dt1 && p.Date < dt2)
				.Select(p => new Payment 
				{ 
					categoryName = p.category.name, 
					price = p.price, 
					count = p.count,
					id = p.id,
					name = p.name,
					Date = p.Date
				})
				.ToArray();

			return bres;
		}

		public IEnumerable<BudgetTitle> GetBudgets(int year, int month)
		{
			var budgets = db.Budgets
				.Include(b => b.Payments)
				.Select(b => new BudgetTitle
				{
					id = b.id,
					name = b.name,
					paymentTotalOfMonth = (decimal)b.Payments
						.Where(p => p.Date.Year == year && p.Date.Month == month)
						.Sum(p => (double)(p.price * p.count))
				})
				.ToList();

			return budgets;
		}
	}
}
