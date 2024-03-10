using Core.Employment.entity;
using Core.Employment.repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment
{
	public class EmplPaymentSourceRepoSQLite : IEmplPaymentSourceRepo
	{
		private readonly AppData db;

		public EmplPaymentSourceRepoSQLite(AppData db)
		{
			this.db = db;
		}
		public IEnumerable<EmplPaymentSource> GetAll()
		{
			return db.EmplPaymentSources
				.Include(x => x.emplPaymentTag)
				.ToArray();
		}
	}
}
