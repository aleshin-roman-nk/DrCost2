using Core.entity;
using Core.services;
using DrCost2.Dto;
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

namespace DrCost2.views
{
	public partial class SpendsOnCategoriesForm : Form, ISpendsOnCategoriesView
	{
		private readonly ProductService productService;
		private readonly ProductCategoryService productCategoryService;

		BindingSource bsComps = new BindingSource();

		public SpendsOnCategoriesForm(ProductService productService,
			ProductCategoryService productCategoryService)
		{
			InitializeComponent();

			this.productService = productService;
			this.productCategoryService = productCategoryService;

			dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

			updateGrid();
		}

		private IEnumerable<ComponedDto> makeComponed(IEnumerable<Product> products)
		{
			var categories = productCategoryService.GetAll();

			//var componedList = products
			//	.GroupBy(p => p.categoryId)
			//	.Select(group => new ComponedDto
			//	{
			//		categoryName = categories.FirstOrDefault(c => c.id == group.Key)?.name,
			//		summ = group.Sum(p => p.sum)
			//	}).ToArray();

			var componedList = products
				.GroupBy(p => new { p.categoryId, p.currencyName })
				.Select(group => new ComponedDto
				{
					categoryName = $"{categories.FirstOrDefault(c => c.id == group.Key.categoryId)?.name} [{group.Key.currencyName}]",
					summ = group.Sum(p => p.sum)
				}).ToArray();

			return componedList;
		}

		void ISpendsOnCategoriesView.ShowDialog()
		{
			this.ShowDialog();
		}

		private void SpendsOnCategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			this.Hide();
		}

		private void updateGrid()
		{
			DateTime dt1 = dateTimePicker1.Value < dateTimePicker2.Value ? dateTimePicker1.Value : dateTimePicker2.Value;
			DateTime dt2 = dateTimePicker1.Value > dateTimePicker2.Value ? dateTimePicker1.Value : dateTimePicker2.Value;

			dt1 = new DateTime(dt1.Year, dt1.Month, dt1.Day, 0, 0, 0);
			dt2 = new DateTime(dt2.Year, dt2.Month, DateTime.DaysInMonth(dt2.Year, dt2.Month), 23, 59, 59);

			var prods = productService.Get(dt1, dt2);

			bsComps.DataSource = makeComponed(prods);

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = bsComps;

			//lblTotal.Text = prods.Sum(x => x.sum).ToString();
			lblTotal.Text = makeSum(prods);
		}

		string makeSum(IEnumerable<Product> prods)
		{
			// LINQ query to create the Componed collection
			var componedList = prods
				.GroupBy(p => new { p.currencyId, p.currencyName })
				.Select(group => new ComponedDto
				{
					categoryName = group.Key.currencyName,
					summ = group.Sum(p => p.sum)
				}).ToList();

			StringBuilder res = new StringBuilder();

			foreach (var comp in componedList)
			{
				// не пугайся, просто класс другое неохото делать, вот categoryName исполняет роль названия валюты )))
				res.Append($"[{comp.summ} {comp.categoryName}] ");
			}

			return res.ToString();
		}

		private void SpendsOnCategoriesForm_Activated(object sender, EventArgs e)
		{
			updateGrid();
		}
	}
}
