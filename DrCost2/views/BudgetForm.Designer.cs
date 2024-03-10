namespace DrCost2.views
{
	partial class BudgetForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			gridCategories = new DataGridView();
			paymentCategoryComponedBindingSource = new BindingSource(components);
			cbMonths = new ComboBox();
			numericYear = new NumericUpDown();
			lblBudgetName = new Label();
			label1 = new Label();
			label2 = new Label();
			lblPaymentTotal = new Label();
			label4 = new Label();
			btnCreatePayment = new Button();
			btnViewDetail = new Button();
			categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			summDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)paymentCategoryComponedBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
			SuspendLayout();
			// 
			// gridCategories
			// 
			gridCategories.AllowUserToAddRows = false;
			gridCategories.AllowUserToDeleteRows = false;
			gridCategories.AllowUserToResizeRows = false;
			gridCategories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridCategories.AutoGenerateColumns = false;
			gridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridCategories.Columns.AddRange(new DataGridViewColumn[] { categoryNameDataGridViewTextBoxColumn, summDataGridViewTextBoxColumn });
			gridCategories.DataSource = paymentCategoryComponedBindingSource;
			gridCategories.Location = new Point(12, 204);
			gridCategories.Name = "gridCategories";
			gridCategories.ReadOnly = true;
			gridCategories.RowHeadersVisible = false;
			gridCategories.RowHeadersWidth = 51;
			gridCategories.RowTemplate.Height = 29;
			gridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridCategories.ShowCellToolTips = false;
			gridCategories.Size = new Size(1075, 428);
			gridCategories.TabIndex = 2;
			// 
			// paymentCategoryComponedBindingSource
			// 
			paymentCategoryComponedBindingSource.DataSource = typeof(UIEntities.PaymentCategoryComponed);
			// 
			// cbMonths
			// 
			cbMonths.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMonths.FormattingEnabled = true;
			cbMonths.Location = new Point(105, 74);
			cbMonths.Name = "cbMonths";
			cbMonths.Size = new Size(275, 36);
			cbMonths.TabIndex = 12;
			cbMonths.SelectedIndexChanged += cbMonths_SelectedIndexChanged;
			// 
			// numericYear
			// 
			numericYear.Location = new Point(12, 74);
			numericYear.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
			numericYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
			numericYear.Name = "numericYear";
			numericYear.Size = new Size(87, 34);
			numericYear.TabIndex = 11;
			numericYear.Value = new decimal(new int[] { 1990, 0, 0, 0 });
			numericYear.ValueChanged += numericYear_ValueChanged;
			// 
			// lblBudgetName
			// 
			lblBudgetName.AutoSize = true;
			lblBudgetName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			lblBudgetName.Location = new Point(12, 23);
			lblBudgetName.Name = "lblBudgetName";
			lblBudgetName.Size = new Size(65, 38);
			lblBudgetName.TabIndex = 13;
			lblBudgetName.Text = "000";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 126);
			label1.Name = "label1";
			label1.Size = new Size(103, 28);
			label1.TabIndex = 14;
			label1.Text = "Выделено";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(121, 126);
			label2.Name = "label2";
			label2.Size = new Size(45, 28);
			label2.TabIndex = 15;
			label2.Text = "000";
			// 
			// lblPaymentTotal
			// 
			lblPaymentTotal.AutoSize = true;
			lblPaymentTotal.Location = new Point(121, 154);
			lblPaymentTotal.Name = "lblPaymentTotal";
			lblPaymentTotal.Size = new Size(45, 28);
			lblPaymentTotal.TabIndex = 17;
			lblPaymentTotal.Text = "000";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 154);
			label4.Name = "label4";
			label4.Size = new Size(74, 28);
			label4.TabIndex = 16;
			label4.Text = "Расход";
			// 
			// btnCreatePayment
			// 
			btnCreatePayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCreatePayment.Location = new Point(1032, 12);
			btnCreatePayment.Name = "btnCreatePayment";
			btnCreatePayment.Size = new Size(55, 44);
			btnCreatePayment.TabIndex = 18;
			btnCreatePayment.Text = "+";
			btnCreatePayment.UseVisualStyleBackColor = true;
			btnCreatePayment.Click += btnCreatePayment_Click;
			// 
			// btnViewDetail
			// 
			btnViewDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnViewDetail.Location = new Point(908, 12);
			btnViewDetail.Name = "btnViewDetail";
			btnViewDetail.Size = new Size(118, 44);
			btnViewDetail.TabIndex = 19;
			btnViewDetail.Text = "View detail";
			btnViewDetail.UseVisualStyleBackColor = true;
			btnViewDetail.Click += btnViewDetail_Click;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			categoryNameDataGridViewTextBoxColumn.HeaderText = "Наименование категории";
			categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			categoryNameDataGridViewTextBoxColumn.Width = 400;
			// 
			// summDataGridViewTextBoxColumn
			// 
			summDataGridViewTextBoxColumn.DataPropertyName = "summ";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			summDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			summDataGridViewTextBoxColumn.HeaderText = "Сумма";
			summDataGridViewTextBoxColumn.MinimumWidth = 6;
			summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
			summDataGridViewTextBoxColumn.ReadOnly = true;
			summDataGridViewTextBoxColumn.Width = 200;
			// 
			// BudgetForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1099, 643);
			Controls.Add(btnViewDetail);
			Controls.Add(btnCreatePayment);
			Controls.Add(lblPaymentTotal);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblBudgetName);
			Controls.Add(cbMonths);
			Controls.Add(numericYear);
			Controls.Add(gridCategories);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "BudgetForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Бюджет подробно";
			FormClosing += MonthBudgetForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)paymentCategoryComponedBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView gridCategories;
		private ComboBox cbMonths;
		private NumericUpDown numericYear;
		private Label lblBudgetName;
		private Label label1;
		private Label label2;
		private Label lblPaymentTotal;
		private Label label4;
		private Button btnCreatePayment;
		private BindingSource paymentCategoryComponedBindingSource;
		private Button btnViewDetail;
		private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
	}
}