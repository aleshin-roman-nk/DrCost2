using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repos
{
	public interface IMonthBudgetRepo: IRepo<MonthBudget>
	{
		public MonthBudget Get(int year, int month);
		public bool Exists(int year, int month);
		MonthBudget Update(MonthBudget mb);
	}
}
