using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.entity
{
	public class EmplMonthDoc
	{
		public int id {  get; set; }
		public string? uname { get; set; } // 2024.02; уникальный ключ-имя
		public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();
		public decimal fot {  get; set; }
		public decimal ops { get; set; }
		public decimal total { get; set; }
	}
}
