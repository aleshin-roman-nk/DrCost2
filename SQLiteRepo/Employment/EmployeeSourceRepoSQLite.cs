using Core.Employment.entity;
using Core.Employment.repos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
		public IEnumerable<EmployeeSource> GetAllActive()
		{
			return _get(onlyActive: true);
		}

		private IEnumerable<EmployeeSource> _get(bool onlyActive)
		{
			var query = db.EmployeeSources.AsQueryable();

			if (onlyActive)
				query = query.Where(x => x.active);

			return query
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
