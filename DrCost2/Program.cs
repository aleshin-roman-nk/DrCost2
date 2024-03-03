using Core;
using Core.repos;
using Core.services;
using DrCost2.views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo;
using DrCost2.Helpers;

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

				.AddSingleton<IPaymentRepo, PaymentRepoSQLite>()
				.AddSingleton<IPaymentSampleRepo, PaymentSampleRepoSqlite>()
				.AddSingleton<IFindingTagRepo, FindingTagRepoSQLite>()
				.AddSingleton<IPaymentCategoryRepo, PaymentCategoryRepoSQLite>()
				.AddSingleton<IBudgetRepo, BudgetsRepo>()

				.AddSingleton<MainForm>()
				.AddSingleton<IInputPaymentView, InputPaymentForm>()
				.AddSingleton<ISelectPaymentSampleView, SelectPaymentSampleForm>()
				.AddSingleton<ICreatePaymentSampleView, CreatePaymentSampleForm>()
				.AddSingleton<IBudgetView, BudgetForm>()
				.AddSingleton<ICreateBudgetView, CreateBudgetForm>()
				.AddSingleton<IInputPaymentView, InputPaymentForm>()
				.AddSingleton<ICreatePaymentsView, CreatePaymentsForm>()

				//.AddSingleton<ProductService>()
				//.AddSingleton<ProductNameService>()
				//.AddSingleton<ProductCategoryService>()
				//.AddSingleton<CurrencyService>()
				//.AddSingleton<MonthMoneyService>()
				//.AddSingleton<FindingTagService>()
				.AddSingleton<BudgetService>()
				.AddSingleton<PaymentSamplePageService>()
				.AddSingleton<MonthsProvider>();

			return services.BuildServiceProvider();
		}
	}
}