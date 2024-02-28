using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
	/// <summary>
	/// Экземпляр бюджета месяца.
	/// В первой версии просто в месяце создается один экземпляр бюджета.
	/// Устанавливается сумма средств.
	/// 
	/// На следующих этапах будут к бюджету прикрепляться категории.
	/// И в ProductName бужет зашито какой это бюджет.
	/// </summary>
	public class MonthBudget
	{
		public int id {  get; set; }
		public string? name { get; set; }
		public decimal money { get; set; }
	}
}
