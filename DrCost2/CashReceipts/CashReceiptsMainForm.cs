using Core.CashReceipts;
using SQLiteRepo.CashReceipts;
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
	public partial class CashReceiptsMainForm : Form, ICashReceiptsMainView
	{
		private readonly ICashReceiptCreatorView cashReceiptCreatorView;
		private readonly CashReceiptService cashReceiptService;

		public event EventHandler PaymentsChanged;

		List<CashReceipt> cashReceipts = new List<CashReceipt>();

		BindingSource bsCashReceiptPayments = new BindingSource();

		bool _dataChanged = false;

		public CashReceiptsMainForm(
			ICashReceiptCreatorView cashReceiptCreatorView,
			CashReceiptService cashReceiptService
			)
		{
			InitializeComponent();
			this.cashReceiptCreatorView = cashReceiptCreatorView;
			this.cashReceiptService = cashReceiptService;
			this.cashReceiptCreatorView.Completed += CashReceiptCreatorView_Completed;

			dataGridViewPayments.AutoGenerateColumns = false;
		}

		private void CashReceiptCreatorView_Completed(object? sender, Core.CashReceipts.dto.CreateCashReceiptDto e)
		{
			if (!e.CreatePaymentDtos.Any())
			{
				MessageBox.Show("Cash receipt is empty and could not be created");
				return;
			}

			cashReceipts.Add(cashReceiptService.Create(e));

			_dataChanged = true;

			placeCashReceipts();
			placeCashReceiptPayments(null);
		}

		private void btnAddCashReceipt_Click(object sender, EventArgs e)
		{
			this.cashReceiptCreatorView.ShowModel();
		}

		public void ShowModal()
		{
			var dt = dateTimePicker1.Value;

			var crs = cashReceiptService.GetAll(dt.Year, dt.Month);

			cashReceipts.Clear();
			cashReceipts.AddRange(crs);

			placeCashReceipts();
			placeCashReceiptPayments(null);

			lblCashReceiptTitle.Text = "-";

			_dataChanged = false;

			this.ShowDialog();
		}

		void placeCashReceipts()
		{
			listViewCashReceipt.Clear();

			IEnumerable<CashReceipt> filtered;

			if (cbWholeMonth.Checked)
			{
				filtered = cashReceipts.OrderByDescending(x => x.Date).ToArray();
			}
			else
			{
				var dt = dateTimePicker1.Value;

				var dtFrom = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
				var dtTo = dtFrom.AddDays(1);

				filtered = cashReceipts
					.Where(cr => cr.Date >= dtFrom && cr.Date < dtTo)
					.OrderByDescending(x => x.Date).ToArray();
			}

			foreach (var cr in filtered)
			{
				ListViewItem item = new ListViewItem(cr.title);
				item.Tag = cr;

				listViewCashReceipt.Items.Add(item);
			}
		}

		void placeCashReceiptPayments(CashReceipt? cr)
		{
			bsCashReceiptPayments.DataSource = null;
			dataGridViewPayments.DataSource = null;

			if (cr == null) return;

			bsCashReceiptPayments.DataSource = cr.Payments;
			dataGridViewPayments.DataSource = bsCashReceiptPayments;
		}

		CashReceipt? getCurrentCashReceipt()
		{
			if (listViewCashReceipt.SelectedItems.Count == 0) return null;

			return listViewCashReceipt.SelectedItems[0].Tag as CashReceipt;
		}

		private void listViewCashReceipt_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cr = getCurrentCashReceipt();

			placeCashReceiptPayments(cr);

			lblCashReceiptTitle.Text = cr == null ? "-" : cr.title;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;

			var crs = cashReceiptService.GetAll(dt.Year, dt.Month);

			cashReceipts.Clear();
			cashReceipts.AddRange(crs);

			placeCashReceipts();
			placeCashReceiptPayments(null);

			lblCashReceiptTitle.Text = "-";
		}

		private void CashReceiptsMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();

			if (_dataChanged)
				PaymentsChanged?.Invoke(this, EventArgs.Empty);
		}

		private void cbWholeMonth_CheckedChanged(object sender, EventArgs e)
		{
			placeCashReceipts();
			placeCashReceiptPayments(null);

			lblCashReceiptTitle.Text = "-";
		}
	}
}
