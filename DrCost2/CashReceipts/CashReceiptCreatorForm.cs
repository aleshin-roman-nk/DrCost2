using Core.CashReceipts;
using Core.CashReceipts.dto;
using Core.dto;
using Core.entity;
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
	public partial class CashReceiptCreatorForm : Form, ICashReceiptCreatorView
	{
		private readonly ICashReceiptPaymentInputView cashReceiptPaymentInputView;

		List<EnteredCashReceiptPaymentDto> enteredCashReceipts = new List<EnteredCashReceiptPaymentDto>();

		BindingSource bsPayments = new BindingSource();

		public event EventHandler<CreateCashReceiptDto> Completed;

		public CashReceiptCreatorForm(
			ICashReceiptPaymentInputView cashReceiptPaymentInputView
			)
		{
			InitializeComponent();
			this.cashReceiptPaymentInputView = cashReceiptPaymentInputView;

			this.cashReceiptPaymentInputView.Completed += CashReceiptPaymentInputView_Completed;

			dataGridViewPayments.AutoGenerateColumns = false;
		}

		private void CashReceiptPaymentInputView_Completed(object? sender, EnteredCashReceiptPaymentDto e)
		{
			enteredCashReceipts.Add(e);

			updatedataGridViewPayments();

			updateSum();
		}

		void updateSum()
		{
			var sum = enteredCashReceipts.Sum(x => x.sum);

			lblSum.Text = sum.ToString("c");
		}

		void updatedataGridViewPayments()
		{
			bsPayments.DataSource = null;
			dataGridViewPayments.DataSource = null;

			bsPayments.DataSource = enteredCashReceipts;
			dataGridViewPayments.DataSource = bsPayments;
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			this.cashReceiptPaymentInputView.ShowModal();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var payments = enteredCashReceipts
				.Select(ecr => new CreatePaymentDto
				{
					Date = dateTimePicker1.Value,
					budgetId = ecr.budgetId,
					name = ecr.name,
					categoryId = ecr.paymentSample.category.id,
					count = ecr.count,
					price = ecr.price,
					paymentSampleId = ecr.paymentSample.id
				});

			var cashReceipt = new CreateCashReceiptDto
			{
				CreatePaymentDtos = payments,
				Date = dateTimePicker1.Value,
				shop = txtShop.Text
			};

			Completed?.Invoke(this, cashReceipt);

			this.Hide();
		}

		private void CashReceiptCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		public void ShowModel()
		{
			enteredCashReceipts.Clear();

			updatedataGridViewPayments();

			updateSum();

			this.ShowDialog();
		}

		EnteredCashReceiptPaymentDto? getCurrent()
		{
			return bsPayments.Current as EnteredCashReceiptPaymentDto;
		}

		private void dataGridViewPayments_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Delete == e.KeyCode)
			{
				var o = getCurrent();

				if(o != null)
				{
					enteredCashReceipts.Remove(o);

					updatedataGridViewPayments();
					updateSum();
				}

				e.Handled = true;
			}
		}
	}
}
