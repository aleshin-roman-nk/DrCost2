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
	public partial class ProductForm : Form, IProductView
	{
		private readonly IProductNameSelectView productTypeSelectView;
		private readonly CurrencyService currencyService;

		public ProductForm(IProductNameSelectView productNameSelectView,
			CurrencyService currencyService)
		{
			InitializeComponent();
			this.productTypeSelectView = productNameSelectView;
			this.currencyService = currencyService;
			productNameSelectView.Completed += ProductTypeSelectView_Completed;

			cbCurrency.DataSource = currencyService.GetAll();
			cbCurrency.DisplayMember = "name";
		}

		private void ProductTypeSelectView_Completed(object? sender, ProductName e)
		{
			setProductName(e);
		}

		private void setProductName(ProductName pname)
		{
			prodName = pname;
			textProductName.Text = pname == null ? "" : prodName.name;
		}

		ProductName prodName { get; set; }

		public event EventHandler<CreateProductDto> Completed;

		private void btnClose_Click(object sender, EventArgs e)
		{
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (prodName == null)
			{
				MessageBox.Show("Имя продукта не выбрано");
				return;
			}

			Completed?.Invoke(this,
				new CreateProductDto
				{
					count = numberCount.Value,
					DateTime = dateTimePicker1.Value,
					price = numberPrice.Value,
					productName = prodName,
					currency = GetCurrency()
				});
			this.Hide();
		}
		Currency GetCurrency()
		{
			Currency? selectedObject = cbCurrency.SelectedItem as Currency;

			if (selectedObject != null)
			{
				return selectedObject;
			}

			return null;
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
