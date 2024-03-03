using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
	/// <summary>
	/// Категория покупки. Например Питание, Хозтовары.
	/// Это не класс бюджета. Просто указание что за покупка.
	/// </summary>
	[Table("PaymentCategories")]
	public class PaymentCategoryDb
	{
		public int id { get; set; }
		public string name { get; set; }
	}
}
