using Core.Employment.entity;
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
	public partial class EmplPaymentEditorForm : Form, IEmplPaymentEditorView
	{
		public EmplPaymentEditorForm()
		{
			InitializeComponent();
		}

		public event EventHandler<EmplPayment>? Completed;

		EmplPayment? _emplPayment = null;

		public void ShowModal(EmplPayment emplPayment)
		{
			_emplPayment = emplPayment;
			placeEmplPayment(_emplPayment);
			this.ShowDialog();
		}

		void placeEmplPayment(EmplPayment emplPayment)
		{
			lblPaymentName.Text = emplPayment.name;
			numPaymentAmount.Value = emplPayment.amount;
			numPaymentPrice.Value = emplPayment.price;
			lblPaymentTotal.Text = emplPayment.sum.ToString();
			txtDescription.Text = emplPayment.description;
			lblTag.Text = emplPayment.tagName;
		}

		EmplPayment take()
		{
			return new EmplPayment
			{
				name = lblPaymentName.Text,
				description = txtDescription.Text,
				completed = _emplPayment.completed,
				amount = numPaymentAmount.Value,
				price = numPaymentPrice.Value,
				employeeId = _emplPayment.employeeId,
				emplPaymentSourceId = _emplPayment.emplPaymentSourceId,
				tagId = _emplPayment.tagId
			};
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Hide();
			Completed?.Invoke(this, take());
		}

		private void EmplPaymentEditorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
