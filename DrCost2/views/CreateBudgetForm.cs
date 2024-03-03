using Core.dto;
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
	public partial class CreateBudgetForm : Form, ICreateBudgetView
	{
		//private bool save = false;

		public event EventHandler<CreateBudgetDto> Completed;

		public CreateBudgetForm()
		{
			InitializeComponent();
		}


		public void ShowModal()
		{
			this.ShowDialog();
		}

		private void CreateBudgetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtBudgetName.Text.Trim()))
			{
				MessageBox.Show("Имя бюджета не должно быть пустым");
				return;
			}

			//save = true;
			Completed?.Invoke(this, new CreateBudgetDto { name = txtBudgetName.Text});
			this.Hide();
		}
	}
}
