using Microsoft.EntityFrameworkCore;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class AppData : DbContext
	{
		public AppData(DbContextOptions<AppData> options) : base(options)
		{
			
		}

		public DbSet<ProductCategoryDb> ProductCategories { get; set; }
		public DbSet<ProductDb> Products { get; set; }
		public DbSet<ProductNameDb> ProductNames { get; set; }
		public DbSet<FindingTagDb> FindingTags { get; set; }
		public DbSet<CurrencyDb> Currencies { get; set; }
	}
}
