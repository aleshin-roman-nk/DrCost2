
using Core.entity;
using Core.services;
using DrCost2.Dto;
using DrCost2.views;
using System.Text;

namespace DrCost2
{
	public partial class MainForm : Form
	{
		private readonly IProductView productView;
		private readonly ProductService productService;
		private readonly ISpendsOnCategoriesView spendsOnCategoriesView;
		private readonly IMonthBudgetView monthBudgetView;
		BindingSource bsProducts = new BindingSource();

		public MainForm(IProductView productView, ProductService productService,
			ISpendsOnCategoriesView spendsOnCategoriesView,
			IMonthBudgetView monthBudgetView)
		{
			InitializeComponent();
			this.productView = productView;
			this.productService = productService;
			this.spendsOnCategoriesView = spendsOnCategoriesView;
			this.monthBudgetView = monthBudgetView;
			this.productView.Completed += ProductView_Completed;

			gridProducts.AutoGenerateColumns = false;

			dateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

			updateProducts();

			gridProducts.DataSource = bsProducts;
		}

		private void ProductView_Completed(object? sender, Dto.CreateProductDto e)
		{
			var prod = new Product
			{
				categoryId = e.productName.ProductCategoryId,
				count = e.count,
				price = e.price,
				Date = e.DateTime,
				name = e.productName.name,
				prodNameId = e.productName.id,
				currencyId = e.currency.id
			};

			productService.Add(prod);
			updateProducts();
		}

		private void createProduct_Click(object sender, EventArgs e)
		{
			productView.ShowModal();
		}

		private void updateProducts()
		{
			DateTime dt1 = dateFrom.Value < dateTo.Value ? dateFrom.Value : dateTo.Value;
			DateTime dt2 = dateFrom.Value > dateTo.Value ? dateFrom.Value : dateTo.Value;

			dt1 = new DateTime(dt1.Year, dt1.Month, dt1.Day, 0, 0, 0);
			dt2 = new DateTime(dt2.Year, dt2.Month, DateTime.DaysInMonth(dt2.Year, dt2.Month), 23, 59, 59);

			var prods = productService.Get(dt1, dt2);

			//var sum = prods.Sum(x => x.sum);
			var sum = makeSum(prods);

			bsProducts.DataSource = prods;

			labelTotal.Text = sum.ToString();

			gridProducts.DataSource = null;
			gridProducts.DataSource = bsProducts;
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

		private void date_ValueChanged(object sender, EventArgs e)
		{
			updateProducts();
		}

		private void btnShowCategories_Click(object sender, EventArgs e)
		{
			spendsOnCategoriesView.ShowDialog();
		}

		private void btnShowBudget_Click(object sender, EventArgs e)
		{
			monthBudgetView.ShowModal();
		}
	}
}