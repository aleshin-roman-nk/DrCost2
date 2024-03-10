using Core.services;
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
	public partial class CashReceiptPaymentInputForm : Form
	{
		private readonly BudgetService budgetService;

		public CashReceiptPaymentInputForm(
			BudgetService budgetService,
			ISelectPaymentSampleView paymentSampleSelectView
			)
		{
			InitializeComponent();
			this.budgetService = budgetService;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

		}
	}
}
