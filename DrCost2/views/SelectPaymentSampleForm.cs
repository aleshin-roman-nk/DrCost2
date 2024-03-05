
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
		private readonly PaymentSampleService paymentSampleService;
		private readonly FindingTagService findingTagService;
		private readonly ICreatePaymentSampleView createPaymentSampleView;

		public event EventHandler<PaymentSample> Completed;

		FindingTag selectedTag { get; set; }
		PaymentSample selectedPaymentSample { get; set; }

		List<PaymentSample> paymentSamples { get; } = new List<PaymentSample>();

		public SelectPaymentSampleForm(
			PaymentSampleService paymentSampleService,
			FindingTagService findingTagService,
			ICreatePaymentSampleView createPaymentSampleView
			)
		{
			InitializeComponent();
			this.paymentSampleService = paymentSampleService;
			this.findingTagService = findingTagService;
			this.createPaymentSampleView = createPaymentSampleView;

			this.createPaymentSampleView.Completed += createPaymentSampleView_Completed;

			paymentSamples.AddRange(paymentSampleService.GetPaymentSamples());

			listBoxFindingTags.DataSource = findingTagService.GetAll();
			listBoxFindingTags.DisplayMember = "name";

			filterPaymentSample(listBoxFindingTags.SelectedItem as FindingTag);

			selectedPaymentSample = getSelectedPaymentSample();
		}

		private void createPaymentSampleView_Completed(object? sender, PaymentSample e)
		{
			paymentSamples.Add(e);
			filterPaymentSample(selectedTag);
		}

		private void ChangeSelectedFindingTag()
		{
			if (listBoxFindingTags.SelectedIndex != -1)
			{
				// Retrieve the selected item
				selectedTag = listBoxFindingTags.SelectedItem as FindingTag;

				// Use the selected item - displaying it in a message box here
				textCategory.Text = selectedTag?.name;

				filterPaymentSample(selectedTag);
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
			createPaymentSampleView.ShowDialog();
		}

		private void listViewPaymentSamples_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedPaymentSample = getSelectedPaymentSample();

			if (selectedPaymentSample == null) return;

			textProductName.Text = selectedPaymentSample.name;
			textProductName.Tag = selectedPaymentSample;
		}

		private void listViewPaymentSamples_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (selectedPaymentSample == null) return;

			Completed?.Invoke(this, selectedPaymentSample);

			this.Hide();
		}

		PaymentSample? getSelectedPaymentSample()
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

		private void filterPaymentSample(FindingTag findingTag)
		{
			var pNames = paymentSamples.Where(x => x.findingTag.id == findingTag.id).ToArray();

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
