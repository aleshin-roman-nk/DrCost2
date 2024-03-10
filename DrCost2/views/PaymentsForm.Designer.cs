namespace DrCost2.views
{
	partial class PaymentsForm
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			dateTimePicker = new DateTimePicker();
			gridPayments = new DataGridView();
			paymentBindingSource = new BindingSource(components);
			lblbudgetName = new Label();
			lvCategories = new ListView();
			splitContainer1 = new SplitContainer();
			cbWholeMonth = new CheckBox();
			btnResetSelectedCategory = new Button();
			lblSum = new Label();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)gridPayments).BeginInit();
			((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// dateTimePicker
			// 
			dateTimePicker.Location = new Point(13, 45);
			dateTimePicker.Margin = new Padding(4);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(256, 34);
			dateTimePicker.TabIndex = 0;
			dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
			// 
			// gridPayments
			// 
			gridPayments.AllowUserToAddRows = false;
			gridPayments.AllowUserToDeleteRows = false;
			gridPayments.AllowUserToResizeRows = false;
			gridPayments.AutoGenerateColumns = false;
			gridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridPayments.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn });
			gridPayments.DataSource = paymentBindingSource;
			gridPayments.Dock = DockStyle.Fill;
			gridPayments.Location = new Point(0, 0);
			gridPayments.Margin = new Padding(4);
			gridPayments.Name = "gridPayments";
			gridPayments.ReadOnly = true;
			gridPayments.RowHeadersVisible = false;
			gridPayments.RowHeadersWidth = 51;
			gridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridPayments.ShowCellToolTips = false;
			gridPayments.Size = new Size(849, 639);
			gridPayments.TabIndex = 1;
			// 
			// paymentBindingSource
			// 
			paymentBindingSource.DataSource = typeof(Core.entity.Payment);
			// 
			// lblbudgetName
			// 
			lblbudgetName.AutoSize = true;
			lblbudgetName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblbudgetName.Location = new Point(13, 9);
			lblbudgetName.Name = "lblbudgetName";
			lblbudgetName.Size = new Size(168, 32);
			lblbudgetName.TabIndex = 2;
			lblbudgetName.Text = "budget-name";
			// 
			// lvCategories
			// 
			lvCategories.Dock = DockStyle.Fill;
			lvCategories.Location = new Point(0, 0);
			lvCategories.Name = "lvCategories";
			lvCategories.Size = new Size(395, 639);
			lvCategories.TabIndex = 3;
			lvCategories.UseCompatibleStateImageBehavior = false;
			lvCategories.View = View.List;
			lvCategories.SelectedIndexChanged += lvCategories_SelectedIndexChanged;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Location = new Point(12, 87);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(gridPayments);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(lvCategories);
			splitContainer1.Size = new Size(1248, 639);
			splitContainer1.SplitterDistance = 849;
			splitContainer1.TabIndex = 4;
			// 
			// cbWholeMonth
			// 
			cbWholeMonth.AutoSize = true;
			cbWholeMonth.Checked = true;
			cbWholeMonth.CheckState = CheckState.Checked;
			cbWholeMonth.Location = new Point(276, 49);
			cbWholeMonth.Name = "cbWholeMonth";
			cbWholeMonth.Size = new Size(154, 32);
			cbWholeMonth.TabIndex = 5;
			cbWholeMonth.Text = "Whole month";
			cbWholeMonth.UseVisualStyleBackColor = true;
			cbWholeMonth.CheckedChanged += cbWholeMonth_CheckedChanged;
			// 
			// btnResetSelectedCategory
			// 
			btnResetSelectedCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnResetSelectedCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnResetSelectedCategory.Location = new Point(1203, 29);
			btnResetSelectedCategory.Name = "btnResetSelectedCategory";
			btnResetSelectedCategory.Size = new Size(57, 39);
			btnResetSelectedCategory.TabIndex = 6;
			btnResetSelectedCategory.Text = "*";
			btnResetSelectedCategory.UseVisualStyleBackColor = true;
			btnResetSelectedCategory.Click += btnResetSelectedCategory_Click;
			// 
			// lblSum
			// 
			lblSum.AutoSize = true;
			lblSum.Location = new Point(461, 51);
			lblSum.Name = "lblSum";
			lblSum.Size = new Size(48, 28);
			lblSum.TabIndex = 7;
			lblSum.Text = "sum";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "name";
			nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			categoryNameDataGridViewTextBoxColumn.HeaderText = "categoryName";
			categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			categoryNameDataGridViewTextBoxColumn.Width = 200;
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
			// priceDataGridViewTextBoxColumn
			// 
			priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
			// sumDataGridViewTextBoxColumn
			// 
			sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			sumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			sumDataGridViewTextBoxColumn.HeaderText = "sum";
			sumDataGridViewTextBoxColumn.MinimumWidth = 6;
			sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
			sumDataGridViewTextBoxColumn.ReadOnly = true;
			sumDataGridViewTextBoxColumn.Width = 125;
			// 
			// PaymentsForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1272, 738);
			Controls.Add(lblSum);
			Controls.Add(btnResetSelectedCategory);
			Controls.Add(cbWholeMonth);
			Controls.Add(splitContainer1);
			Controls.Add(lblbudgetName);
			Controls.Add(dateTimePicker);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "PaymentsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Покупки";
			((System.ComponentModel.ISupportInitialize)gridPayments).EndInit();
			((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker;
		private DataGridView gridPayments;
		private Label lblbudgetName;
		private ListView lvCategories;
		private SplitContainer splitContainer1;
		private CheckBox cbWholeMonth;
		private BindingSource paymentBindingSource;
		private Button btnResetSelectedCategory;
		private Label lblSum;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
	}
}