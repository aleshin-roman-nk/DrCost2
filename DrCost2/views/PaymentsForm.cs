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
using System.Xml.Linq;

namespace DrCost2.views
{
	public partial class PaymentsForm : Form, IPaymentsView
	{
		private readonly BudgetService budgetService;
		private readonly PaymentCategoryService paymentCategoryService;
		Budget? budget = null;
		int budgetYear;
		int budgetMonth;
		PaymentCategory? selectedCategory
		{
			get
			{
				if (lvCategories.SelectedItems.Count > 0)
				{
					var res = lvCategories.SelectedItems[0].Tag as PaymentCategory;

					return res;
				}

				return null;
			}
		}

		BindingSource bsPayments = new BindingSource();

		public PaymentsForm(
			BudgetService budgetService,
			PaymentCategoryService paymentCategoryService
			)
		{
			InitializeComponent();
			this.budgetService = budgetService;
			this.paymentCategoryService = paymentCategoryService;
		}

		//public void ShowModal(int budgetId, int year, int month, int categoryId = 0)
		public void ShowModal(int budgetId)
		{
			setCategories(paymentCategoryService.GetAll());

			budgetYear = dateTimePicker.Value.Year;
			budgetMonth = dateTimePicker.Value.Month;

			budget = budgetService.GetBudget(budgetId, budgetYear, budgetMonth);
			setPayments(budget.Payments);

			setBudgetTitle(
				budget.name,
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				"");

			this.ShowDialog();
		}

		private void setPayments(IEnumerable<Payment> payments)
		{
			bsPayments.DataSource = null;
			gridPayments.DataSource = null;

			decimal sum = 0;

			if (cbWholeMonth.Checked)
			{
				bsPayments.DataSource = payments.OrderByDescending(p => p.Date);
				sum = payments.Sum(x => x.sum);
			}
			else
			{
				var dt = dateTimePicker.Value;
				var dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
				var dt2 = dt1.AddDays(1);

				var filtered = payments
					.Where(x => x.Date >= dt1 && x.Date < dt2)
					.OrderByDescending(p => p.Date)
					.ToArray();

				bsPayments.DataSource = filtered;

				sum = filtered.Sum(x => x.sum);
			}

			lblSum.Text = sum.ToString("c");
			gridPayments.DataSource = bsPayments;
		}

		private void setCategories(IEnumerable<PaymentCategory> categories)
		{
			lvCategories.Clear();

			foreach (var category in categories)
			{
				ListViewItem item = new ListViewItem(category.name);
				item.Tag = category;

				lvCategories.Items.Add(item);
			}
		}

		private void lvCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectedCategory == null) return;

			setBudgetTitle(
				budget.name,
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				selectedCategory.name);

			var payments = budget.Payments.Where(x => x.categoryName.ToLower().Equals(selectedCategory.name.ToLower())).ToArray();

			setPayments(payments);
		}

		private void btnResetSelectedCategory_Click(object sender, EventArgs e)
		{
			if (budget == null) return;
			if (budget.Payments == null) return;

			lvCategories.SelectedItems.Clear();

			setBudgetTitle(
				budget.name, 
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				"");

			var payments = budget.Payments;

			setPayments(payments);
		}

		void setBudgetTitle(string budgetName, int year, int month, string? categoryName)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"{budgetName} [{year}.{month}]");

			if (!string.IsNullOrEmpty(categoryName))
				sb.Append($" : {categoryName}");

			lblbudgetName.Text = sb.ToString();
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			if(budget == null) return;
			if(budget.Payments == null) return;

			budget = adjustBudgetToYearMonth(
				budget, 
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month);

			setPayments(budget.Payments);

			setBudgetTitle(
				budget.name,
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				selectedCategory == null ? "" : selectedCategory.name);
		}

		private void cbWholeMonth_CheckedChanged(object sender, EventArgs e)
		{
			if (budget == null) return;
			if (budget.Payments == null) return;

			setPayments(budget.Payments);

			setBudgetTitle(
				budget.name,
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				selectedCategory == null ? "" : selectedCategory.name);
		}

		Budget adjustBudgetToYearMonth(Budget b, int year, int month)
		{
			if (budget == null) throw new InvalidOperationException($"Budget refference is lost");

			if (budgetYear != year || budgetMonth != month)
			{
				budgetYear = year;
				budgetMonth = month;
				return budgetService.GetBudget(b.id, year, month);
			}
			else
				return b;
		}
	}
}
