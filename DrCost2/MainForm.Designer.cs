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
			button2 = new Button();
			label1 = new Label();
			labelTotal = new Label();
			gridProducts = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sum = new DataGridViewTextBoxColumn();
			currencyName = new DataGridViewTextBoxColumn();
			productBindingSource = new BindingSource(components);
			dateFrom = new DateTimePicker();
			dateTo = new DateTimePicker();
			btnShowCategories = new Button();
			btnShowBudget = new Button();
			((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(1018, 13);
			button2.Margin = new Padding(4);
			button2.Name = "button2";
			button2.Size = new Size(69, 41);
			button2.TabIndex = 1;
			button2.Text = "+";
			button2.UseVisualStyleBackColor = true;
			button2.Click += createProduct_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 12);
			label1.Name = "label1";
			label1.Size = new Size(89, 28);
			label1.TabIndex = 2;
			label1.Text = "расходы";
			// 
			// labelTotal
			// 
			labelTotal.AutoSize = true;
			labelTotal.Location = new Point(105, 12);
			labelTotal.Name = "labelTotal";
			labelTotal.Size = new Size(23, 28);
			labelTotal.TabIndex = 3;
			labelTotal.Text = "0";
			// 
			// gridProducts
			// 
			gridProducts.AllowUserToAddRows = false;
			gridProducts.AllowUserToDeleteRows = false;
			gridProducts.AllowUserToResizeRows = false;
			gridProducts.AutoGenerateColumns = false;
			gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridProducts.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, sum, currencyName });
			gridProducts.DataSource = productBindingSource;
			gridProducts.Location = new Point(12, 117);
			gridProducts.Name = "gridProducts";
			gridProducts.ReadOnly = true;
			gridProducts.RowHeadersVisible = false;
			gridProducts.RowHeadersWidth = 51;
			gridProducts.RowTemplate.Height = 29;
			gridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridProducts.Size = new Size(1076, 501);
			gridProducts.TabIndex = 4;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "name";
			nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 400;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			priceDataGridViewTextBoxColumn.HeaderText = "price";
			priceDataGridViewTextBoxColumn.MinimumWidth = 6;
			priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			priceDataGridViewTextBoxColumn.ReadOnly = true;
			priceDataGridViewTextBoxColumn.Width = 125;
			// 
			// countDataGridViewTextBoxColumn
			// 
			countDataGridViewTextBoxColumn.DataPropertyName = "count";
			countDataGridViewTextBoxColumn.HeaderText = "count";
			countDataGridViewTextBoxColumn.MinimumWidth = 6;
			countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			countDataGridViewTextBoxColumn.ReadOnly = true;
			countDataGridViewTextBoxColumn.Width = 125;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dateDataGridViewTextBoxColumn.HeaderText = "Date";
			dateDataGridViewTextBoxColumn.MinimumWidth = 6;
			dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			dateDataGridViewTextBoxColumn.ReadOnly = true;
			dateDataGridViewTextBoxColumn.Width = 125;
			// 
			// sum
			// 
			sum.DataPropertyName = "sum";
			sum.HeaderText = "sum";
			sum.MinimumWidth = 6;
			sum.Name = "sum";
			sum.ReadOnly = true;
			sum.Width = 125;
			// 
			// currencyName
			// 
			currencyName.DataPropertyName = "currencyName";
			currencyName.HeaderText = "CR";
			currencyName.MinimumWidth = 6;
			currencyName.Name = "currencyName";
			currencyName.ReadOnly = true;
			currencyName.Width = 80;
			// 
			// productBindingSource
			// 
			productBindingSource.DataSource = typeof(Core.entity.Product);
			// 
			// dateFrom
			// 
			dateFrom.Location = new Point(12, 54);
			dateFrom.Name = "dateFrom";
			dateFrom.Size = new Size(250, 34);
			dateFrom.TabIndex = 5;
			dateFrom.ValueChanged += date_ValueChanged;
			// 
			// dateTo
			// 
			dateTo.Location = new Point(285, 54);
			dateTo.Name = "dateTo";
			dateTo.Size = new Size(250, 34);
			dateTo.TabIndex = 6;
			dateTo.ValueChanged += date_ValueChanged;
			// 
			// btnShowCategories
			// 
			btnShowCategories.Location = new Point(941, 13);
			btnShowCategories.Name = "btnShowCategories";
			btnShowCategories.Size = new Size(70, 41);
			btnShowCategories.TabIndex = 7;
			btnShowCategories.Text = "cat";
			btnShowCategories.UseVisualStyleBackColor = true;
			btnShowCategories.Click += btnShowCategories_Click;
			// 
			// btnShowBudget
			// 
			btnShowBudget.Location = new Point(872, 13);
			btnShowBudget.Name = "btnShowBudget";
			btnShowBudget.Size = new Size(63, 41);
			btnShowBudget.TabIndex = 8;
			btnShowBudget.Text = "bdg";
			btnShowBudget.UseVisualStyleBackColor = true;
			btnShowBudget.Click += btnShowBudget_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 630);
			Controls.Add(btnShowBudget);
			Controls.Add(btnShowCategories);
			Controls.Add(dateTo);
			Controls.Add(dateFrom);
			Controls.Add(gridProducts);
			Controls.Add(labelTotal);
			Controls.Add(label1);
			Controls.Add(button2);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button2;
		private Label label1;
		private Label labelTotal;
		private DataGridView gridProducts;
		private BindingSource productBindingSource;
		private DateTimePicker dateFrom;
		private DateTimePicker dateTo;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sum;
		private DataGridViewTextBoxColumn currencyName;
		private Button btnShowCategories;
		private Button btnShowBudget;
	}
}