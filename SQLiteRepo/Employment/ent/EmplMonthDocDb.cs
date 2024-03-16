using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment.ent
{
	[Table("EmplMonthDocs")]
	public class EmplMonthDocDb
	{
		public int id { get; set; }
		public string? uname { get; set; } // 2024.02; уникальный ключ-имя
		public IEnumerable<EmployeeDb> Employees { get; set; } = new List<EmployeeDb>();
	}
}
