using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment.ent
{
	[Table("Employees")]
	public class EmployeeDb
	{
		public int id { get; set; }
		public int employeeSourceId { get; set; }
		public int payDocId { get; set; }
		public string? name { get; set; }
		public ICollection<EmplPaymentDb> Payments { get; set; } = new List<EmplPaymentDb>();
		public bool cash { get; set; }
	}
}
