using Core;
using Core.repos;
using Core.services;
using DrCost2.views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MockRepo;
using SQLiteRepo;

namespace DrCost2
{
    internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			ApplicationConfiguration.Initialize();

			// Set up dependency injection
			IServiceProvider serviceProvider = ConfigureServices(new ServiceCollection());

			var mainForm = serviceProvider.GetService<MainForm>();

			Application.Run(mainForm);
		}

		private static IServiceProvider ConfigureServices(ServiceCollection services)
		{
			// Add DbContext with SQLite provider
			services

				.AddDbContext<AppData>(options =>
					options.UseSqlite("Data Source=..\\..\\db\\report.sqlite"))

				.AddSingleton<IProductRepo, ProductRepoSQLite>()
				.AddSingleton<IProductNameRepo, ProductNameRepoSqlite>()
				.AddSingleton<IFindingTagRepo, FindingTagRepoSQLite>()
				.AddSingleton<ICategoryRepo, ProductCategoryRepoSQLite>()
				.AddSingleton<ICurrencyRepo, CurrencyRepoSQLite>()
				.AddSingleton<IMonthBudgetRepo, MonthBudgedRepoSQLite>()

				.AddSingleton<MainForm>()
				.AddSingleton<IProductView, ProductForm>()
				.AddSingleton<IProductNameSelectView, ProductNameSelectForm>()
				.AddSingleton<IProductNameView, ProductNameForm>()
				.AddSingleton<ISpendsOnCategoriesView, SpendsOnCategoriesForm>()
				.AddSingleton<IMonthBudgetView, MonthBudgetForm>()

				.AddSingleton<ProductService>()
				.AddSingleton<ProductNameService>()
				.AddSingleton<ProductCategoryService>()
				.AddSingleton<CurrencyService>()
				.AddSingleton<MonthMoneyService>()
				.AddSingleton<FindingTagService>();

			return services.BuildServiceProvider();
		}
	}
}