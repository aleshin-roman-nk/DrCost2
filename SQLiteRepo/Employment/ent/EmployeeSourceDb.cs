using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment.ent
{
	public class EmployeeSourceDb
	{
		public int id { get; set; }
		public string? name { get; set; }
		public bool cash { get; set; }
		public bool active {  get; set; } = true;
	}
}
