using Core.Employment.entity;
using Core.Employment.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrCost2.views.Employment
{
	public partial class EmplMonthDocForm : Form, IEmplMonthDocView
	{
		private readonly IEmplPaymentSourceSelectorView paymentSourceSelectorView;
		private readonly IEmplPaymentEditorView emplPaymentEditorView;
		private readonly EmplMonthDocService emplMonthDocService;
		BindingSource bsEmployees = new BindingSource();
		BindingSource bsPayments = new BindingSource();

		Employee? curentEmployee
		{
			get
			{
				if (bsEmployees.CurrencyManager.Position < bsEmployees.Count)
					return bsEmployees.Current as Employee;
				else return null;
			}
		}
			
		EmplPayment? currentEmplPayment => bsPayments.Current as EmplPayment;

		DateTime currentDate;

		public EmplMonthDocForm(
			IEmplPaymentSourceSelectorView paymentSourceSelectorView,
			IEmplPaymentEditorView emplPaymentEditorView,
			EmplMonthDocService emplMonthDocService
			)
		{
			InitializeComponent();
			this.paymentSourceSelectorView = paymentSourceSelectorView;
			this.emplPaymentEditorView = emplPaymentEditorView;
			this.emplMonthDocService = emplMonthDocService;
			this.paymentSourceSelectorView.EmplPaymentSourceSelected += PaymentSourceSelectorView_EmplPaymentSourceSelected;
			this.bsEmployees.CurrentItemChanged += BsEmployees_CurrentItemChanged;
			this.emplPaymentEditorView.Completed += EmplPaymentEditorView_Completed;

			this.emplMonthDocService.OnEmplMonthDocChanged += EmplMonthDocService_OnEmplMonthDocChanged;

			currentDate = DateTime.Now;
		}

		/*
		 * Updating 3 sections:
		 * - totals
		 * - employees
		 * - employees paymnts
		 */
		private void EmplMonthDocService_OnEmplMonthDocChanged(object? sender, EmplMonthDoc? e)
		{
			int? lastSelectedEmployee = null;

			if (curentEmployee != null)
				lastSelectedEmployee = curentEmployee.id;

			// rendering code
			renderMonthDocument(e);

			// place cursor
			if (lastSelectedEmployee == null) return;

			DataGridViewRow? targetRow = null;
			foreach (DataGridViewRow row in gridEmployees.Rows)
			{
				Employee rowData = (Employee)row.DataBoundItem;
				if (rowData.id == lastSelectedEmployee)
				{
					targetRow = row;
					break;
				}
			}

			if (targetRow != null)
			{
				targetRow.Selected = true;
				gridEmployees.CurrentCell = gridEmployees[0, targetRow.Index];
			}
		}

		private void BsEmployees_CurrentItemChanged(object? sender, EventArgs e)
		{
			if (curentEmployee == null)
			{
				txtCurrentEmployee.Text = "-";
				renderEmplPayments(null);
				return;
			}

			txtCurrentEmployee.Text = curentEmployee.name;
			renderEmplPayments(curentEmployee.Payments);
		}

		private void PaymentSourceSelectorView_EmplPaymentSourceSelected(object? sender, EmplPaymentSource e)
		{
			if (curentEmployee == null) return;

			//построить из сырца (payment-source) реальный платеж
			var paymentToCreate = new EmplPayment
			{
				amount = 1,
				description = "",
				employeeId = curentEmployee.id,
				emplPaymentSourceId = e.id,
				name = e.name,
				price = e.price,
				tagId = e.tagId,
				tagName = e.tagName,
				completed = false
			};

			emplPaymentEditorView.ShowModal(paymentToCreate);
		}

		public void ShowModal()
		{
			var dt = dateTimePicker1.Value;

			emplMonthDocService.loadDocument(dt.Year, dt.Month);

			currentDate = dateTimePicker1.Value;

			this.ShowDialog();
		}

		private void btnCreateDocument_Click(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;
			var docname = $"{dt.Year}.{dt.Month}";

			emplMonthDocService.CreateNewDoc(dt.Year, dt.Month);
		}

		private void btnAddEmpl_Click(object sender, EventArgs e)
		{

		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			this.paymentSourceSelectorView.ShowModal();
		}

		private void EmploymentDocForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void renderMonthDocument(EmplMonthDoc? doc)
		{
			if (doc == null)
			{
				btnCreateDocument.Enabled = true;
				btnAddEmpl.Enabled = false;
				btnAddPayment.Enabled = false;
				btnAddAllEmployees.Enabled = false;
				btnCloneDocumentImage.Enabled = false;
				lblDocName.Text = "-none-";
				lblTotalSum.Text = "-";
				lblFotTotal.Text = "-";
				lblKhozTotal.Text = "-";
				lblOpsTotal.Text = "-";

				renderEmployees(null);
			}
			else
			{
				btnCreateDocument.Enabled = false;
				btnAddEmpl.Enabled = true;
				btnAddPayment.Enabled = true;
				btnAddAllEmployees.Enabled = true;
				btnCloneDocumentImage.Enabled = true;
				lblDocName.Text = doc.uname;
				lblTotalSum.Text = doc.total.ToString("c");
				lblFotTotal.Text = doc.fot.ToString("c");
				lblKhozTotal.Text = "-";
				lblOpsTotal.Text = doc.ops.ToString("c");

				renderEmployees(doc.Employees);
			}
		}

		private void renderEmplPayments(IEnumerable<EmplPayment>? payments)
		{
			bsPayments.DataSource = null;
			gridEmplPayment.DataSource = null;

			if (payments != null)
			{
				bsPayments.DataSource = payments;
				gridEmplPayment.DataSource = bsPayments;
			}
		}

		private void renderEmployees(IEnumerable<Employee>? employees)
		{
			bsEmployees.DataSource = null;
			gridEmployees.DataSource = null;

			if (employees != null)
			{
				if (employees.Count() > 0)
				{
					bsEmployees.DataSource = employees.OrderBy(x => x.name);
					gridEmployees.DataSource = bsEmployees;
				}
			}
		}

		private void btnAddAllEmployees_Click(object sender, EventArgs e)
		{
			emplMonthDocService.EnsureAllActiveCreated();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;

			if (dt.Year == currentDate.Year && dt.Month == currentDate.Month) return;

			this.emplMonthDocService.loadDocument(dt.Year, dt.Month);

			currentDate = dt;
		}

		private void gridEmplPayment_KeyDown(object sender, KeyEventArgs e)
		{
			if (Keys.Delete == e.KeyCode)
			{
				var empl = curentEmployee;
				var pay = currentEmplPayment;

				if (empl == null) return;
				if (pay == null) return;

				var c = MessageBox.Show($"Are you sure to delete payment {pay.name}?",
					"Confirm", MessageBoxButtons.YesNo);

				if (c == DialogResult.Yes)
				{
					emplMonthDocService.DeleteEmplPayment(pay);
				}

				e.Handled = true;
			}
			else if (Keys.Enter == e.KeyCode)
			{
				if (currentEmplPayment == null) return;

				emplPaymentEditorView.ShowModal(currentEmplPayment);

				e.Handled = true;
			}
		}

		private void EmplPaymentEditorView_Completed(object? sender, EmplPayment e)
		{
			if (e.id == 0)
				emplMonthDocService.CreateEmplPayment(e);
			else
				emplMonthDocService.UpdateEmplPayment(e);

		}

		private void gridEmplPayment_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (currentEmplPayment == null) return;

			emplPaymentEditorView.ShowModal(currentEmplPayment);
		}

		private void btnCloneDocumentImage_Click(object sender, EventArgs e)
		{
			var dtDest = dateTimePicker1.Value;
			var dtSrc = dtDest.AddMonths(-1);

			emplMonthDocService.CloneLastDocumentInto(dtSrc.Year, dtSrc.Month, dtDest.Year, dtDest.Month);
		}

		private void gridEmployees_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Delete == e.KeyCode)
			{
				if(curentEmployee == null) return;
				var ok = MessageBox.Show($"Are you sure to delete {curentEmployee.name}", "Deleting", MessageBoxButtons.YesNo);
				if(ok != DialogResult.Yes) return;

				emplMonthDocService.DeleteEmployee(curentEmployee);

				e.Handled = true;
			}
		}
	}
}
