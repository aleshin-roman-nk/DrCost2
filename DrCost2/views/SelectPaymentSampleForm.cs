
using Core.entity;
using Core.services;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrCost2.views
{
	public partial class SelectPaymentSampleForm : Form, ISelectPaymentSampleView
	{
		private readonly PaymentSamplePageService paymentSamplePageService;
		private readonly ICreatePaymentSampleView productNameView;

		public event EventHandler<PaymentSample> Completed;

		FindingTag selectedTag { get; set; }
		PaymentSample selectedProductName { get; set; }

		List<PaymentSample> productNames { get; } = new List<PaymentSample>();

		public SelectPaymentSampleForm(
			//ProductNameService productNameService,
			//ProductCategoryService productCategoryService,
			PaymentSamplePageService paymentSamplePageService,
			ICreatePaymentSampleView createPaymentSampleView
			)
		{
			InitializeComponent();
			this.paymentSamplePageService = paymentSamplePageService;
			//this.productNameService = productNameService;
			//this.findingTagService = findingTagService;
			this.productNameView = createPaymentSampleView;

			this.productNameView.Completed += ProductNameView_Completed;

			//productNames.AddRange(productNameService.GetAll());

			listBoxFindingTags.DataSource = paymentSamplePageService.GetFindingTags();
			listBoxFindingTags.DisplayMember = "name";

			//updateProductNameListView(productNameService.GetAll());
			filterProductNames(listBoxFindingTags.SelectedItem as FindingTag);

			selectedProductName = getSelectedProductName();
		}

		private void ProductNameView_Completed(object? sender, PaymentSample e)
		{
			//pushProductName(e);
			productNames.Add(e);
			filterProductNames(selectedTag);
		}

		private void ChangeSelectedFindingTag()
		{
			if (listBoxFindingTags.SelectedIndex != -1)
			{
				// Retrieve the selected item
				selectedTag = listBoxFindingTags.SelectedItem as FindingTag;

				// Use the selected item - displaying it in a message box here
				textCategory.Text = selectedTag?.name;

				filterProductNames(selectedTag);
			}
			else
			{
				MessageBox.Show("No item selected.");
			}
		}

		private void ProductTypeSelectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			//this.Hide();

			//Completed?.Invoke(this, null);
		}

		public void ShowModal()
		{
			this.ShowDialog();
			//this.Focus();
		}

		private void btnAddProductName_Click(object sender, EventArgs e)
		{
			productNameView.ShowDialog();
		}

		private void listViewProductNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedProductName = getSelectedProductName();

			if (selectedProductName == null) return;

			textProductName.Text = selectedProductName.name;
			textProductName.Tag = selectedProductName;
		}

		private void listViewProductNames_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (selectedProductName == null) return;

			Completed?.Invoke(this, selectedProductName);

			this.Hide();
		}

		PaymentSample? getSelectedProductName()
		{
			if (lvPaymentSamples.SelectedItems.Count > 0)
			{
				var res = lvPaymentSamples.SelectedItems[0].Tag as PaymentSample;

				return res;
			}

			return null;
		}

		private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeSelectedFindingTag();
		}

		private void filterProductNames(FindingTag findingTag)
		{
			var pNames = productNames.Where(x => x.findingTag.id == findingTag.id).ToArray();

			lvPaymentSamples.Clear();

			foreach (var pName in pNames)
			{
				ListViewItem item = new ListViewItem(pName.name);
				item.Tag = pName;

				lvPaymentSamples.Items.Add(item);
			}
		}
	}
}
