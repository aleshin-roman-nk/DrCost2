using Core.dto;
using Core.entity;
using Core.services;
using DrCost2.Dto;
using System;
using System.Collections.ObjectModel;
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
		private readonly PaymentService paymentService;
		ObservableCollection<EnteredPaymentDto> paymentsToBeCreated = new ObservableCollection<EnteredPaymentDto>();

		BindingSource bsPayments = new BindingSource();

		int currentBudgetId = 0;

		public CreatePaymentsForm(
			IInputPaymentView inputPaymentView,
			PaymentService paymentService
			)
		{
			InitializeComponent();
			this.inputPaymentView = inputPaymentView;
			this.paymentService = paymentService;
			inputPaymentView.Completed += InputPaymentView_Completed;

			gridPayments.AutoGenerateColumns = false;

			bsPayments.DataSource = paymentsToBeCreated;
			gridPayments.DataSource = bsPayments;
		}

		private void InputPaymentView_Completed(object? sender, EnteredPaymentDto e)
		{
			paymentsToBeCreated.Add(e);

			bsPayments.DataSource = null;
			gridPayments.DataSource = null;

			bsPayments.DataSource = paymentsToBeCreated;
			gridPayments.DataSource = bsPayments;
		}

		public event EventHandler PaymentsChanged;

		public void ShowModal(int budgetId)
		{
			currentBudgetId = budgetId;
			paymentsToBeCreated.Clear();
			this.ShowDialog();
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			inputPaymentView.ShowModal();
		}

		private void btnCreateAndClose_Click(object sender, EventArgs e)
		{
			if (currentBudgetId == 0) throw new InvalidDataException("Budget is not defined");

			var toSave = paymentsToBeCreated.Select(p => new CreatePaymentDto
			{
				budgetId = currentBudgetId,
				categoryId = p.paymentSample.category.id,
				count = p.count,
				Date = p.DateTime,
				name = p.name,
				price = p.price
			});

			paymentService.CreateRange(toSave);

			PaymentsChanged?.Invoke(this, EventArgs.Empty);

			this.Hide();
		}
	}
}
