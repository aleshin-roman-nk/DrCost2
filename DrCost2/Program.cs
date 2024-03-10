using Core;
using Core.repos;
using Core.services;
using DrCost2.views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo;
using DrCost2.Helpers;
using DrCost2.views.Employment;
using Core.Employment.services;
using Core.Employment.repos;
using SQLiteRepo.Employment;

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

			Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalUnhandledExceptionHandler);

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
					//options.UseSqlite(@"Data Source=..\..\db\report.sqlite")
					options.UseSqlite(@"Data Source=db\report.sqlite")
					)

				.AddSingleton<IPaymentRepo, PaymentRepoSQLite>()
				.AddSingleton<IPaymentSampleRepo, PaymentSampleRepoSqlite>()
				.AddSingleton<IFindingTagRepo, FindingTagRepoSQLite>()
				.AddSingleton<IPaymentCategoryRepo, PaymentCategoryRepoSQLite>()
				.AddSingleton<IBudgetRepo, BudgetsRepo>()
				.AddSingleton<IEmploymentDocRepo, EmploymentDocRepoSQLite>()
				.AddSingleton<IEmployeeRepo, EmployeeRepoSQLite>()
				.AddSingleton<IEmployeeSourceRepo, EmployeeSourceRepoSQLite>()
				.AddSingleton<IEmplPaymentSourceRepo, EmplPaymentSourceRepoSQLite>()
				.AddSingleton<IEmplPaymentRepo, EmplPaymentRepoSQLite>()

				.AddSingleton<MainForm>()
				.AddSingleton<IInputPaymentView, InputPaymentForm>()
				.AddSingleton<ISelectPaymentSampleView, SelectPaymentSampleForm>()
				.AddSingleton<ICreatePaymentSampleView, CreatePaymentSampleForm>()
				.AddSingleton<IBudgetView, BudgetForm>()
				.AddSingleton<ICreateBudgetView, CreateBudgetForm>()
				.AddSingleton<IInputPaymentView, InputPaymentForm>()
				.AddSingleton<ICreatePaymentsView, CreatePaymentsForm>()
				.AddSingleton<IPaymentsView, PaymentsForm>()
				.AddSingleton<IEmploymentDocView, EmploymentDocForm>()
				.AddSingleton<IEmplPaymentSourceSelectorView, EmplPaymentSourceSelectorForm>()
				.AddSingleton<IEmplPaymentEditorView, EmplPaymentEditorForm>()
				.AddSingleton<IInputStringView, InputStringForm>()
				.AddSingleton<IPartitionManagerView, PartitionManagerForm>()

				.AddSingleton<PaymentService>()
				.AddSingleton<PaymentCategoryService>()
				.AddSingleton<BudgetService>()
				.AddSingleton<PaymentSampleService>()
				.AddSingleton<FindingTagService>()
				.AddSingleton<MonthsProvider>()
				.AddSingleton<EmploymentDocService>()
				.AddSingleton<EmplPaymentSourceService>();

			return services.BuildServiceProvider();
		}

		private static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//Application.Exit();
		}

		// Handle non-UI thread exceptions
		private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show("A critical error occurred. The application will now close.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//Application.Exit();
		}
	}
}