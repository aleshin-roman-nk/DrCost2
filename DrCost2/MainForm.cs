
using Core.entity;
using Core.services;
using DrCost2.Helpers;
using DrCost2.UIEntities;
using DrCost2.views;
using System.Text;

namespace DrCost2
{
    public partial class MainForm : Form
	{
		private readonly IBudgetView budgetView;
		private readonly ICreateBudgetView createBudgetView;
		private readonly MonthsProvider monthsProvider;
		private readonly BudgetService budgetService;
		BindingSource bsBudgets = new BindingSource();

		List<BudgetTitle> budgetTitles;

		public MainForm(
			IBudgetView budgetView,
			ICreateBudgetView createBudgetView,
			MonthsProvider monthsProvider,
			BudgetService budgetService
			)
		{
			InitializeComponent();
			this.budgetView = budgetView;
			this.createBudgetView = createBudgetView;
			this.monthsProvider = monthsProvider;
			this.budgetService = budgetService;

			//this.productView.Completed += ProductView_Completed;
			this.createBudgetView.Completed += CreateBudgetView_Completed;

			gridBudgets.AutoGenerateColumns = false;

			cbMonths.DataSource = monthsProvider.Months;
			cbMonths.DisplayMember = "name";

			setCurrentYearAndMonth();

			updateData();
		}

		private void CreateBudgetView_Completed(object? sender, Core.dto.CreateBudgetDto e)
		{
			budgetService.CreateBudget(e);
			updateData();
		}

		//private void ProductView_Completed(object? sender, Dto.CreateProductDto e)
		//{
		//	var prod = new Product
		//	{
		//		categoryId = e.productName.ProductCategoryId,
		//		count = e.count,
		//		price = e.price,
		//		Date = e.DateTime,
		//		name = e.productName.name,
		//		prodNameId = e.productName.id,
		//		currencyId = e.currency.id
		//	};

		//	productService.Add(prod);
		//	updateProducts();
		//}

		private void setCurrentYearAndMonth()
		{
			var today = DateTime.Today;

			numericYear.Value = today.Year;

			Month selectedMonth = monthsProvider.Months.First(m => m.month == today.Month);
			cbMonths.SelectedItem = selectedMonth;
		}

		private void btnCreateBudget_Click(object sender, EventArgs e)
		{
			createBudgetView.ShowModal();
		}

		private void numericYear_ValueChanged(object sender, EventArgs e)
		{
			updateData();
		}

		private void cbMonths_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateData();
		}

		private void updateData()
		{
			budgetTitles = budgetService.GetBudgets(Convert.ToInt32(numericYear.Value), (cbMonths.SelectedItem as Month).month).ToList();

			bsBudgets.DataSource = null;
			gridBudgets.DataSource = null;
			bsBudgets.DataSource = budgetTitles;
			gridBudgets.DataSource = bsBudgets;
		}

		private BudgetTitle _currentBudget => bsBudgets.Current as BudgetTitle;

		private void gridBudgets_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				if(bsBudgets.DataSource != null)
				{
					budgetView.ShowModal(_currentBudget.id);
				}
				e.Handled = true;
			}
		}
	}
}