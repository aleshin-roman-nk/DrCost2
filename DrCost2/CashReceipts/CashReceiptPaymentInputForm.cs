using Core.entity;
using Core.services;
using DrCost2.Dto;
using DrCost2.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrCost2.CashReceipts
{
	public partial class CashReceiptPaymentInputForm : Form, ICashReceiptPaymentInputView
	{
		private readonly BudgetService budgetService;
		private readonly ISelectPaymentSampleView paymentSampleSelectView;

		PaymentSample? paymentSample { get; set; } = null;

		public CashReceiptPaymentInputForm(
			BudgetService budgetService,
			ISelectPaymentSampleView paymentSampleSelectView
			)
		{
			InitializeComponent();
			this.budgetService = budgetService;
			this.paymentSampleSelectView = paymentSampleSelectView;

			this.paymentSampleSelectView.Completed += PaymentSampleSelectView_Completed;
		}

		private void PaymentSampleSelectView_Completed(object? sender, PaymentSample e)
		{
			setPaymentSample(e);
		}

		public event EventHandler<EnteredCashReceiptPaymentDto> Completed;

		public void ShowModal()
		{
			loadBudgetsAndSet();
			setPaymentSample(null);
			numberPrice.Value = 0;
			numberCount.Value = 1;

			this.ShowDialog();
		}

		void loadBudgetsAndSet()
		{
			cbBudgets.DataSource = null;
			cbBudgets.DataSource = budgetService.GetBudgetTitleNames();
			cbBudgets.DisplayMember = "name";
		}

		void setPaymentSample(PaymentSample? p)
		{
			paymentSample = p;
			textPaymentSample.Text = p == null ? string.Empty : p.name;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (paymentSample == null)
			{
				MessageBox.Show("Имя продукта не выбрано");
				return;
			}

			Completed?.Invoke(this,
				new EnteredCashReceiptPaymentDto
				{
					count = numberCount.Value,
					price = numberPrice.Value,
					paymentSample = this.paymentSample,
					budgetId = ((BudgetTitleName)cbBudgets.SelectedItem).id,
					budgetName = ((BudgetTitleName)cbBudgets.SelectedItem).name
				});
			this.Hide();
		}

		private void btnSelectPaymentSampe_Click(object sender, EventArgs e)
		{
			paymentSampleSelectView.ShowModal();
		}

		private void CashReceiptPaymentInputForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
