using Core.entity;
using Core.services;
using DrCost2.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DrCost2.views
{
	public partial class InputPaymentForm : Form, IInputPaymentView
	{
		private readonly ISelectPaymentSampleView productTypeSelectView;

		public InputPaymentForm(ISelectPaymentSampleView paymentSampleSelectView)
		{
			InitializeComponent();
			this.productTypeSelectView = paymentSampleSelectView;
			paymentSampleSelectView.Completed += ProductTypeSelectView_Completed;

		}

		private void ProductTypeSelectView_Completed(object? sender, PaymentSample e)
		{
			setProductName(e);
		}

		private void setProductName(PaymentSample psample)
		{
			paymentSample = psample;
			textProductName.Text = psample == null ? "" : paymentSample.name;
		}

		PaymentSample paymentSample { get; set; }

		public event EventHandler<EnteredPaymentDto> Completed;

		private void btnClose_Click(object sender, EventArgs e)
		{
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (paymentSample == null)
			{
				MessageBox.Show("Имя продукта не выбрано");
				return;
			}

			Completed?.Invoke(this,
				new EnteredPaymentDto
				{
					count = numberCount.Value,
					DateTime = dateTimePicker1.Value,
					price = numberPrice.Value,
					paymentSample = this.paymentSample
				});
			this.Hide();
		}

		private void ProductView_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnSelectType_Click(object sender, EventArgs e)
		{
			productTypeSelectView.ShowModal();
		}

		public void ShowModal()
		{
			setProductName(null);
			numberCount.Value = 1;
			numberPrice.Value = 0;
			this.ShowDialog();
			//this.Focus();
		}

		private void ProductForm_Activated(object sender, EventArgs e)
		{
			//numberPrice.Value = 0;
			//setProductName(null);
		}
	}
}
