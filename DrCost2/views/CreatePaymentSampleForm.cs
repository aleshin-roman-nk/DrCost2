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
		//private readonly FindingTagService findingTagService;
		//private readonly ProductCategoryService productCategoryService;
		//private readonly ProductNameService productNameService;

		public CreatePaymentSampleForm(
			//FindingTagService findingTagService,
			//ProductCategoryService productCategoryService,
			//ProductNameService productNameService
			)
		{
			InitializeComponent();
			//this.findingTagService = findingTagService;
			//this.productCategoryService = productCategoryService;
			//this.productNameService = productNameService;
			//cbFindingTag.DataSource = findingTagService.GetAll();
			//cbFindingTag.DisplayMember = "name";

			//cbCategory.DataSource = productCategoryService.GetAll();
			//cbCategory.DisplayMember = "name";
		}

		public event EventHandler<PaymentSample> Completed;

		private void btnAccept_Click(object sender, EventArgs e)
		{
			//if (string.IsNullOrEmpty(textProductName.Text)) return;

			//var selectedTag = (FindingTag)cbFindingTag.SelectedItem;
			//var selectedCategory = (PaymentCategory)cbCategory.SelectedItem;

			//PaymentSample pName = new PaymentSample
			//{
			//	findingTagId = selectedTag.id,
			//	name = textProductName.Text,
			//	ProductCategoryId = selectedCategory.id
			//};

			//pName = productNameService.Add(pName);

			//Completed?.Invoke(this, pName);

			//this.Hide();
		}

		private void ProductNameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		void ICreatePaymentSampleView.ShowDialog()
		{
			this.ShowDialog();
		}
	}
}
