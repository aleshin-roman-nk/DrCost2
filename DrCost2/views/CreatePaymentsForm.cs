using Core.entity;
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
	public partial class CreatePaymentsForm : Form, ICreatePaymentsView
	{
		private readonly IInputPaymentView inputPaymentView;

		List<EnteredPaymentDto> paymentsToBeCreated = new List<EnteredPaymentDto>();

		BindingSource bsPayments = new BindingSource();

		public CreatePaymentsForm(IInputPaymentView inputPaymentView)
		{
			InitializeComponent();
			this.inputPaymentView = inputPaymentView;

			inputPaymentView.Completed += InputPaymentView_Completed;

			bsPayments.DataSource = paymentsToBeCreated;
			gridPayments.DataSource = bsPayments;
		}

		private void InputPaymentView_Completed(object? sender, EnteredPaymentDto e)
		{
			throw new NotImplementedException();
		}

		public event EventHandler<bool> Completed;

		public void ShowModal(int budgetId)
		{
			this.ShowDialog();
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			inputPaymentView.ShowModal();
		}
	}
}
