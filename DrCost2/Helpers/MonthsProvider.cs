using DrCost2.UIEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.Helpers
{
    public class MonthsProvider
	{
		Month[] months = new Month[]
		{
					new Month { month = 1, name = "Январь"},
					new Month { month = 2, name = "Февраль"},
					new Month { month = 3, name = "Март"},
					new Month { month = 4, name = "Апрель"},
					new Month { month = 5, name = "Май"},
					new Month { month = 6, name = "Июнь"},
					new Month { month = 7, name = "Июль"},
					new Month { month = 8, name = "Август"},
					new Month { month = 9, name = "Сентябрь"},
					new Month { month = 10, name = "Октябрь"},
					new Month { month = 11, name = "Ноябрь"},
					new Month { month = 12, name = "Декабрь"},
		};

		public IEnumerable<Month> Months { get { return months; } }
	}
}
