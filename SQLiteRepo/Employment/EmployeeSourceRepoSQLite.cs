using Core.Employment.entity;
using Core.Employment.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment
{
	public class EmployeeSourceRepoSQLite : IEmployeeSourceRepo
	{
		private readonly AppData db;

		public EmployeeSourceRepoSQLite(AppData db)
		{
			this.db = db;
		}
		public IEnumerable<EmployeeSource> GetAll()
		{
			return db.EmployeeSources
				.Select(eSrc => new EmployeeSource
				{
					cash = eSrc.cash,
					id = eSrc.id,
					name = eSrc.name
				})
				.ToArray();
		}
	}
}
