using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class AppDataFactory : IDesignTimeDbContextFactory<AppData>
	{
		public AppData CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppData>();
			optionsBuilder.UseSqlite("Data Source=bin\\db\\report.sqlite");

			return new AppData(optionsBuilder.Options);
		}
	}
}
