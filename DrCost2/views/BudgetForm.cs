using Core.entity;
using Core.services;
using DrCost2.Helpers;
using DrCost2.UIEntities;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DrCost2.views
{
	public partial class BudgetForm : Form, IBudgetView
	{
		private readonly MonthsProvider monthsProvider;
		private readonly BudgetService budgetService;
		private readonly ICreatePaymentsView createPaymentsView;

		public event EventHandler Completed;

		BindingSource bsCategories = new BindingSource();

		// если добавлен платеж, устанавливается в true
		private bool _changed = false;

		private Budget? _budget = null;

		public BudgetForm(
			MonthsProvider monthsProvider,
			BudgetService budgetService,
			ICreatePaymentsView createPaymentsView
			)
		{
			InitializeComponent();
			this.monthsProvider = monthsProvider;
			this.budgetService = budgetService;
			this.createPaymentsView = createPaymentsView;
			cbMonths.DataSource = monthsProvider.Months;
			cbMonths.DisplayMember = "name";
		}
		public void ShowModal(int budgetId)
		{
			setCurrentYearAndMonth();

			Month selectedMonth = cbMonths.SelectedItem as Month;
			_budget = budgetService.GetBudget(budgetId, (int)numericYear.Value, selectedMonth.month);

			placeObject(_budget);

			this.ShowDialog();
		}

		private void setCurrentYearAndMonth()
		{
			var today = DateTime.Today;

			numericYear.Value = today.Year;

			Month selectedMonth = monthsProvider.Months.First(m => m.month == today.Month);
			cbMonths.SelectedItem = selectedMonth;
		}

		private void MonthBudgetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private IEnumerable<PaymentCategoryComponed> buildCategoriesComponed(IEnumerable<Payment> payments)
		{
			// Grouping payments by category and calculating the sum
			var groupedPayments = payments
				.GroupBy(p => p.categoryName)
				.Select(g => new PaymentCategoryComponed
				{
					categoryName = g.Key,
					summ = g.Sum(p => p.sum)
				})
				.ToList();

			return groupedPayments;
		}

		private void placeObject(Budget b)
		{
			lblBudgetName.Text = b.name;
			lblPaymentTotal.Text = b.Payments.Sum(x => x.sum).ToString();

			bsCategories.DataSource = null;
			gridCategories.DataSource = null;

			bsCategories.DataSource = buildCategoriesComponed(b.Payments);
			gridCategories.DataSource = bsCategories;
		}

		private void updateGudget()
		{
			if (_budget == null) return;
			_budget = budgetService.GetBudget(_budget.id, (int)numericYear.Value, (cbMonths.SelectedItem as Month).month);
			placeObject(_budget);
		}

		private void numericYear_ValueChanged(object sender, EventArgs e)
		{
			updateGudget();
		}

		private void cbMonths_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateGudget();
		}

		private void btnCreatePayment_Click(object sender, EventArgs e)
		{
			createPaymentsView.ShowModal(_budget.id);
		}
	}
}
