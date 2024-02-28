using Core.services;
using DrCost2.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrCost2.views
{
	public partial class MonthBudgetForm : Form, IMonthBudgetView
	{
		int[] years = new int[] { 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030 };

		MonthDto[] months = new MonthDto[]
		{
			new MonthDto { month = 2, name = "Февраль"},
			new MonthDto { month = 1, name = "Январь"},
			new MonthDto { month = 3, name = "Март"},
			new MonthDto { month = 4, name = "Апрель"},
			new MonthDto { month = 5, name = "Май"},
			new MonthDto { month = 6, name = "Июнь"},
			new MonthDto { month = 7, name = "Июль"},
			new MonthDto { month = 8, name = "Август"},
			new MonthDto { month = 9, name = "Сентябрь"},
			new MonthDto { month = 10, name = "Октябрь"},
			new MonthDto { month = 11, name = "Ноябрь"},
			new MonthDto { month = 12, name = "Декабрь"},
		};

		private readonly ProductService productService;
		private readonly MonthMoneyService monthMoneyService;

		public MonthBudgetForm(ProductService productService,
			MonthMoneyService monthMoneyService)
		{
			InitializeComponent();

			cbYears.DataSource = years;

			cbMonths.DataSource = months;
			cbMonths.DisplayMember = "name";

			setCurrentYearAndMonth();
			this.productService = productService;
			this.monthMoneyService = monthMoneyService;
		}

		public void ShowModal()
		{
			this.ShowDialog();
		}

		private void setCurrentYearAndMonth()
		{
			var today = DateTime.Today;

			cbYears.SelectedItem = today.Year;

			MonthDto selectedMonth = months.FirstOrDefault(m => m.month == today.Month);
			cbMonths.SelectedItem = selectedMonth;
		}

		private decimal getSpends(int year, int month /*, int currencyId*/)
		{

		}

		private void MonthBudgetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void lblBudgetNoney_Click(object sender, EventArgs e)
		{
			textBoxEnterBudget.Text = lblBudgetNoney.Text;
			textBoxEnterBudget.Visible = true;
			textBoxEnterBudget.Focus();
		}

		private void textBoxEnterBudget_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				textBoxEnterBudget.Visible = false;
				lblBudgetNoney.Text = textBoxEnterBudget.Text;
				textBoxEnterBudget.Text = "";
			}
			else if(e.KeyCode == Keys.Escape)
			{
				textBoxEnterBudget.Visible = false;
			}
		}
	}
}
