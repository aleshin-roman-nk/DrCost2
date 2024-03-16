using Core.Employment.entity;
using Core.Employment.services;
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
	public partial class EmplPaymentSourceSelectorForm : Form, IEmplPaymentSourceSelectorView
	{
		private readonly EmplPaymentSourceService emplPaymentSourceService;

		public EmplPaymentSourceSelectorForm(
			EmplPaymentSourceService emplPaymentSourceService
			)
		{
			InitializeComponent();
			this.emplPaymentSourceService = emplPaymentSourceService;
		}

		public event EventHandler<EmplPaymentSource>? EmplPaymentSourceSelected;

		BindingSource bsPaymentSource = new BindingSource();

		EmplPaymentSource _current => bsPaymentSource.Current as EmplPaymentSource;

		public void ShowModal()
		{
			bsPaymentSource.DataSource = emplPaymentSourceService.GetAll();
			gridEmplPaymentSources.DataSource = bsPaymentSource;

			this.ShowDialog();
		}

		private void gridEmplPaymentSources_KeyDown(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode)
			{
				e.Handled = true;
				this.Hide();
				EmplPaymentSourceSelected?.Invoke(this, _current);
			}
		}

		private void EmplPaymentSourceSelectorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void gridEmplPaymentSources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.Hide();
			EmplPaymentSourceSelected?.Invoke(this, _current);
		}
	}
}
