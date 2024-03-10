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
using System.Xml.Linq;

namespace DrCost2.views
{
	public partial class PartitionManagerForm : Form, IPartitionManagerView
	{
		private readonly IInputStringView inputStringView;
		private readonly FindingTagService findingTagService;
		private readonly PaymentCategoryService paymentCategoryService;

		List<FindingTag> findingTags;
		List<PaymentCategory> paymentCategories;

		public PartitionManagerForm(
			IInputStringView inputStringView,
			FindingTagService findingTagService,
			PaymentCategoryService paymentCategoryService
			)
		{
			InitializeComponent();
			this.inputStringView = inputStringView;
			this.findingTagService = findingTagService;
			this.paymentCategoryService = paymentCategoryService;
		}

		private void btnAddFindingTag_Click(object sender, EventArgs e)
		{
			if (this.inputStringView.ShowModal("Новый поисковый тег"))
			{
				var fTag = findingTagService.Create(inputStringView.output);
				findingTags.Add(fTag);
				placeFindingTags(findingTags);
			}
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			if (this.inputStringView.ShowModal("Новая категория"))
			{
				var pCategory = paymentCategoryService.Create(inputStringView.output);
				paymentCategories.Add(pCategory);
				placeCategories(paymentCategories);
			}
		}

		public void ShowModal()
		{
			findingTags = findingTagService.GetAll().ToList();
			paymentCategories = paymentCategoryService.GetAll().ToList();

			placeFindingTags(findingTags);
			placeCategories(paymentCategories);

			this.ShowDialog();
		}

		private void PartitionManagerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		void placeFindingTags(IEnumerable<FindingTag> findingTags)
		{
			listViewFindingTags.Clear();

			foreach (var fTag in findingTags)
			{
				ListViewItem item = new ListViewItem(fTag.name);
				item.Tag = fTag;

				listViewFindingTags.Items.Add(item);
			}
		}

		void placeCategories(IEnumerable<PaymentCategory> paymentCategories)
		{
			listViewPaymentCategories.Clear();

			foreach (var pCategory in paymentCategories)
			{
				ListViewItem item = new ListViewItem(pCategory.name);
				item.Tag = pCategory;

				listViewPaymentCategories.Items.Add(item);
			}
		}
	}
}
