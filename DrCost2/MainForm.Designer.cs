namespace DrCost2
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			btnCreateBudget = new Button();
			numericYear = new NumericUpDown();
			cbMonths = new ComboBox();
			gridBudgets = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			paymentTotalOfMonthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			budgetTitleBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridBudgets).BeginInit();
			((System.ComponentModel.ISupportInitialize)budgetTitleBindingSource).BeginInit();
			SuspendLayout();
			// 
			// btnCreateBudget
			// 
			btnCreateBudget.Location = new Point(840, 539);
			btnCreateBudget.Margin = new Padding(4);
			btnCreateBudget.Name = "btnCreateBudget";
			btnCreateBudget.Size = new Size(247, 41);
			btnCreateBudget.TabIndex = 1;
			btnCreateBudget.Text = "Create new budget";
			btnCreateBudget.UseVisualStyleBackColor = true;
			btnCreateBudget.Click += btnCreateBudget_Click;
			// 
			// numericYear
			// 
			numericYear.Location = new Point(12, 14);
			numericYear.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
			numericYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
			numericYear.Name = "numericYear";
			numericYear.Size = new Size(87, 34);
			numericYear.TabIndex = 9;
			numericYear.Value = new decimal(new int[] { 1990, 0, 0, 0 });
			numericYear.ValueChanged += numericYear_ValueChanged;
			// 
			// cbMonths
			// 
			cbMonths.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMonths.FormattingEnabled = true;
			cbMonths.Location = new Point(105, 12);
			cbMonths.Name = "cbMonths";
			cbMonths.Size = new Size(275, 36);
			cbMonths.TabIndex = 10;
			cbMonths.SelectedIndexChanged += cbMonths_SelectedIndexChanged;
			// 
			// gridBudgets
			// 
			gridBudgets.AllowUserToAddRows = false;
			gridBudgets.AutoGenerateColumns = false;
			gridBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridBudgets.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, paymentTotalOfMonthDataGridViewTextBoxColumn });
			gridBudgets.DataSource = budgetTitleBindingSource;
			gridBudgets.Location = new Point(13, 54);
			gridBudgets.Name = "gridBudgets";
			gridBudgets.ReadOnly = true;
			gridBudgets.RowHeadersWidth = 51;
			gridBudgets.RowTemplate.Height = 29;
			gridBudgets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridBudgets.ShowCellToolTips = false;
			gridBudgets.Size = new Size(1075, 478);
			gridBudgets.TabIndex = 11;
			gridBudgets.KeyDown += gridBudgets_KeyDown;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "Budget name";
			nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 400;
			// 
			// paymentTotalOfMonthDataGridViewTextBoxColumn
			// 
			paymentTotalOfMonthDataGridViewTextBoxColumn.DataPropertyName = "paymentTotalOfMonth";
			paymentTotalOfMonthDataGridViewTextBoxColumn.HeaderText = "Budget total";
			paymentTotalOfMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
			paymentTotalOfMonthDataGridViewTextBoxColumn.Name = "paymentTotalOfMonthDataGridViewTextBoxColumn";
			paymentTotalOfMonthDataGridViewTextBoxColumn.ReadOnly = true;
			paymentTotalOfMonthDataGridViewTextBoxColumn.Width = 150;
			// 
			// budgetTitleBindingSource
			// 
			budgetTitleBindingSource.DataSource = typeof(Core.entity.BudgetTitle);
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 592);
			Controls.Add(gridBudgets);
			Controls.Add(cbMonths);
			Controls.Add(numericYear);
			Controls.Add(btnCreateBudget);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
			((System.ComponentModel.ISupportInitialize)gridBudgets).EndInit();
			((System.ComponentModel.ISupportInitialize)budgetTitleBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button btnCreateBudget;
		private NumericUpDown numericYear;
		private ComboBox cbMonths;
		private DataGridView gridBudgets;
		private BindingSource budgetTitleBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentTotalOfMonthDataGridViewTextBoxColumn;
	}
}