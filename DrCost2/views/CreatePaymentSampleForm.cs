using Core.dto;
using Core.entity;
using Core.services;
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
	public partial class CreatePaymentSampleForm : Form, ICreatePaymentSampleView
	{
		private readonly FindingTagService findingTagService;
		private readonly PaymentCategoryService paymentCategoryService;
		private readonly PaymentSampleService paymentSampleService;

		public CreatePaymentSampleForm(
			FindingTagService findingTagService,
			PaymentCategoryService paymentCategoryService,
			PaymentSampleService paymentSampleService
			)
		{
			InitializeComponent();
			this.findingTagService = findingTagService;
			this.paymentCategoryService = paymentCategoryService;
			this.paymentSampleService = paymentSampleService;
		}

		public event EventHandler<PaymentSample> Completed;

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textProductName.Text)) return;

			var selectedTag = (FindingTag)cbFindingTag.SelectedItem;
			var selectedCategory = (PaymentCategory)cbCategory.SelectedItem;

			CreatePaymentSampleDto pSample = new CreatePaymentSampleDto
			{
				tagId = selectedTag.id,
				name = textProductName.Text,
				categoryId = selectedCategory.id
			};

			var newPs = paymentSampleService.Create(pSample);

			Completed?.Invoke(this, newPs);

			this.Hide();
		}

		private void ProductNameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		void ICreatePaymentSampleView.ShowDialog()
		{
			cbFindingTag.DataSource = null;
			cbCategory.DataSource = null;

			cbFindingTag.DataSource = this.findingTagService.GetAll();
			cbFindingTag.DisplayMember = "name";

			cbCategory.DataSource = this.paymentCategoryService.GetAll();
			cbCategory.DisplayMember = "name";

			this.ShowDialog();
		}
	}
}
