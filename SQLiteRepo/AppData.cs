using Core.Employment.entity;
using Core.entity;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo.CashReceipts;
using SQLiteRepo.Employment.ent;
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

			modelBuilder.Entity<EmplPaymentDb>()
				.HasOne(p => p.EmplPaymentTag)
				.WithMany()
				.HasForeignKey(p => p.tagId);

			//EmployeeDb
			modelBuilder.Entity<EmployeeDb>()
				.HasMany(p => p.Payments)
				.WithOne()
				.HasForeignKey(p => p.employeeId);

			//PaymentMainDocDb
			modelBuilder.Entity<EmplMonthDocDb>()
				.HasMany(d => d.Employees)
				.WithOne()
				.HasForeignKey(e => e.payDocId);

			//EmplPaymentSource
			modelBuilder.Entity<EmplPaymentSource>()
				.HasOne(p => p.emplPaymentTag)
				.WithMany()
				.HasForeignKey(p => p.tagId);

			//modelBuilder.Entity<PaymentCategory>()
			//	.ToTable("PaymentCategories");

			modelBuilder.Entity<CashReceiptDb>()
				.HasMany(cr => cr.Payments)
				.WithOne()
				.HasForeignKey(p => p.cashReceiptId);
		}

		public DbSet<PaymentCategory> PaymentCategories { get; set; }
		//public DbSet<PaymentCategoryDb> PaymentCategories { get; set; }
		public DbSet<PaymentDb> Payments { get; set; }
		public DbSet<PaymentSampleDb> PaymentSamples { get; set; }
		public DbSet<FindingTagDb> FindingTags { get; set; }
		public DbSet<BudgetDb> Budgets { get; set; }

		public DbSet<EmplMonthDocDb> EmplMonthDocs { get; set; }
		public DbSet<EmployeeDb> Employees { get; set; }
		public DbSet<EmployeeSourceDb> EmployeeSources { get; set; }
		public DbSet<EmplPaymentTag> EmplPaymentTags { get; set; }
		public DbSet<EmplPaymentSource> EmplPaymentSources { get; set; }
		public DbSet<EmplPaymentDb> EmplPayments { get; set; }
		public DbSet<CashReceiptDb> CashReceipts { get; set; }
	}
}
