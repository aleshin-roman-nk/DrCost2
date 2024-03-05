using Core.entity;
using Core.services;
using DrCost2.Helpers;
using DrCost2.UIEntities;
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
		PaymentCategory? selectedCategory = null;

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

			int year = dateTimePicker.Value.Year;
			int month = dateTimePicker.Value.Month;

			budget = budgetService.GetBudget(budgetId, year, month);
			setPayments(budget.Payments);

			lblbudgetName.Text = budget.name;

			this.ShowDialog();
		}

		private void setPayments(IEnumerable<Payment> payments)
		{
			bsPayments.DataSource = null;
			gridPayments.DataSource = null;

			bsPayments.DataSource = payments;
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
			selectedCategory = getSelectedCategory();

			if (selectedCategory == null) return;

			lblbudgetName.Text = $"{budget.name}:{selectedCategory.name}";

			var payments = budget.Payments.Where(x => x.categoryName.ToLower().Equals(selectedCategory.name.ToLower())).ToArray();

			setPayments(payments);
		}

		private PaymentCategory? getSelectedCategory()
		{
			if (lvCategories.SelectedItems.Count > 0)
			{
				var res = lvCategories.SelectedItems[0].Tag as PaymentCategory;

				return res;
			}

			return null;
		}

		private void btnAllCategories_Click(object sender, EventArgs e)
		{
			selectedCategory = null;

			lblbudgetName.Text = budget.name;

			var payments = budget.Payments;

			setPayments(payments);
		}
	}
}
