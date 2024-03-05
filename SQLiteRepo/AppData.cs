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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BudgetDb>()
				.HasMany(b => b.Payments)
				.WithOne() // Assuming PaymentDb does not have a navigation property back to BudgetDb
				.HasForeignKey(p => p.budgetId); // Replace YourForeignKeyPropertyName with the actual name of the foreign key property in PaymentDb

			modelBuilder.Entity<PaymentSampleDb>()
				.HasOne(p => p.category)
				.WithMany()
				.HasForeignKey(p => p.categoryId);
		}

		public DbSet<PaymentCategoryDb> PaymentCategories { get; set; }
		public DbSet<PaymentDb> Payments { get; set; }
		public DbSet<PaymentSampleDb> PaymentSamples { get; set; }
		public DbSet<FindingTagDb> FindingTags { get; set; }
		public DbSet<BudgetDb> Budgets { get; set; }
	}
}
