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
	public partial class InputStringForm : Form, IInputStringView
	{
		bool ok = false;

		public InputStringForm()
		{
			InitializeComponent();
		}

		public string output => textBox1.Text;

		public bool ShowModal(string msg)
		{
			textBox1.Text = "";

			lblPrompt.Text = msg;
			this.ShowDialog();

			return ok;
		}

		private void InputStringForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			ok = true;
			this.Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ok = false;
			this.Hide();
		}
	}
}
