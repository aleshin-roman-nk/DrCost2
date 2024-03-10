using Core.Employment.entity;
using Core.Employment.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrCost2.views.Employment
{
	public partial class EmploymentDocForm : Form, IEmploymentDocView
	{
		private readonly EmploymentDocService employmentDocService;
		private readonly IEmplPaymentSourceSelectorView paymentSourceSelectorView;
		private readonly IEmplPaymentEditorView emplPaymentEditorView;

		private PaymentMainDoc? paymentMainDoc = null;

		BindingSource bsEmployees = new BindingSource();
		BindingSource bsPayments = new BindingSource();

		Employee _curentEmployee => bsEmployees.Current as Employee;

		public EmploymentDocForm(
			EmploymentDocService employmentDocService,
			IEmplPaymentSourceSelectorView paymentSourceSelectorView,
			IEmplPaymentEditorView emplPaymentEditorView
			)
		{
			InitializeComponent();
			this.employmentDocService = employmentDocService;
			this.paymentSourceSelectorView = paymentSourceSelectorView;
			this.emplPaymentEditorView = emplPaymentEditorView;
			this.paymentSourceSelectorView.EmplPaymentSourceSelected += PaymentSourceSelectorView_EmplPaymentSourceSelected;
			this.bsEmployees.CurrentItemChanged += BsEmployees_CurrentItemChanged;
			this.emplPaymentEditorView.Completed += EmplPaymentEditorView_Completed;
		}

		private void EmplPaymentEditorView_Completed(object? sender, EmplPayment e)
		{
			var newPayment = employmentDocService.Add(e);
			var newList = _curentEmployee.Payments.ToList();
			newList.Add(newPayment);
			_curentEmployee.Payments = newList;
			placeEmplPayments(_curentEmployee.Payments);
			lblFotTotal.Text = calcFot(paymentMainDoc);
			lblOpsTotal.Text = calcOps(paymentMainDoc);
			lblTotalSum.Text = calcTotal(paymentMainDoc);
		}

		private void BsEmployees_CurrentItemChanged(object? sender, EventArgs e)
		{
			if (_curentEmployee == null) return;

			txtCurrentEmployee.Text = _curentEmployee.name;
			placeEmplPayments(_curentEmployee.Payments);
		}

		private void PaymentSourceSelectorView_EmplPaymentSourceSelected(object? sender, EmplPaymentSource e)
		{
			//построить из сырца (payment-source) реальный платеж
			var paymentToCreate = new EmplPayment
			{
				amount = 1,
				description = "",
				employeeId = _curentEmployee.id,
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
			//1. load document if exists
			var dt = dateTimePicker1.Value;
			var docname = $"{dt.Year}.{dt.Month}";

			paymentMainDoc = employmentDocService.Get(docname);

			placeDocAndUpdateFace(paymentMainDoc);

			this.ShowDialog();
		}

		private void btnAddDoc_Click(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;
			var docname = $"{dt.Year}.{dt.Month}";

			var doc = employmentDocService.Create(docname);

			if (doc == null) MessageBox.Show($"Document {docname} already exists");

			placeDocAndUpdateFace(doc);
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

		// 
		private void placeDocAndUpdateFace(PaymentMainDoc? doc)
		{
			paymentMainDoc = doc;

			if (paymentMainDoc == null)
			{
				btnAddDoc.Enabled = true;
				btnAddEmpl.Enabled = false;
				btnAddPayment.Enabled = false;
				btnAddAllEmployees.Enabled = false;
				lblDocName.Text = "-none-";
				lblTotalSum.Text = "0";
				lblFotTotal.Text = "0";
				lblKhozTotal.Text = "0";
				lblOpsTotal.Text = "0";

				placeEmployeesToGrid(null);
			}
			else
			{
				btnAddDoc.Enabled = false;
				btnAddEmpl.Enabled = true;
				btnAddPayment.Enabled = true;
				btnAddAllEmployees.Enabled = true;
				lblDocName.Text = paymentMainDoc.uname;
				lblTotalSum.Text = calcTotal(paymentMainDoc);
				lblFotTotal.Text = calcFot(paymentMainDoc);
				lblKhozTotal.Text = "0";
				lblOpsTotal.Text = calcOps(paymentMainDoc);

				placeEmployeesToGrid(paymentMainDoc.Employees);
			}
		}

		private void placeEmplPayments(IEnumerable<EmplPayment> payments)
		{
			bsPayments.DataSource = null;
			gridEmplPayment.DataSource = null;

			bsPayments.DataSource = payments;
			gridEmplPayment.DataSource = bsPayments;
		}

		private void placeEmployeesToGrid(IEnumerable<Employee>? employees)
		{
			gridEmployees.DataSource = null;
			bsEmployees.DataSource = null;

			if (employees != null)
			{
				bsEmployees.DataSource = employees;
				gridEmployees.DataSource = bsEmployees;
			}
		}

		string calcTotal(PaymentMainDoc d)
		{
			return d.Employees.Sum(x => x.sum).ToString();
		}

		string calcFot(PaymentMainDoc d)
		{
			decimal fot = 0;

			foreach (var employee in d.Employees)
			{
				fot += employee.Payments
					.Where(p => p.tagName.Equals("FOT"))
					.Sum(x => x.sum);
			}

			return $"Фот: {fot}";
		}

		string calcOps(PaymentMainDoc d)
		{
			decimal ops = 0;

			foreach (var employee in d.Employees)
			{
				ops += employee.Payments
					.Where(p => p.tagName.Equals("OPS"))
					.Sum(x => x.sum);
			}

			return $"ОПС: {ops}";
		}

		private void btnAddAllEmployees_Click(object sender, EventArgs e)
		{
			if (paymentMainDoc == null) return;

			employmentDocService.AddAllEmployees(paymentMainDoc);

			placeDocAndUpdateFace(paymentMainDoc);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;
			var docname = $"{dt.Year}.{dt.Month}";

			paymentMainDoc = employmentDocService.Get(docname);

			placeDocAndUpdateFace(paymentMainDoc);
		}
	}
}
