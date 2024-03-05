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
			dateTimePicker = new DateTimePicker();
			gridPayments = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			paymentBindingSource = new BindingSource(components);
			lblbudgetName = new Label();
			lvCategories = new ListView();
			splitContainer1 = new SplitContainer();
			cbWholeMonth = new CheckBox();
			btnAllCategories = new Button();
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
			dateTimePicker.Location = new Point(13, 38);
			dateTimePicker.Margin = new Padding(4);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(256, 29);
			dateTimePicker.TabIndex = 0;
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
			gridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridPayments.ShowCellToolTips = false;
			gridPayments.Size = new Size(849, 652);
			gridPayments.TabIndex = 1;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "name";
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			categoryNameDataGridViewTextBoxColumn.HeaderText = "categoryName";
			categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			categoryNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dateDataGridViewTextBoxColumn.HeaderText = "Date";
			dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			priceDataGridViewTextBoxColumn.HeaderText = "price";
			priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			countDataGridViewTextBoxColumn.DataPropertyName = "count";
			countDataGridViewTextBoxColumn.HeaderText = "count";
			countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sumDataGridViewTextBoxColumn
			// 
			sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
			sumDataGridViewTextBoxColumn.HeaderText = "sum";
			sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
			sumDataGridViewTextBoxColumn.ReadOnly = true;
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
			lblbudgetName.Size = new Size(133, 25);
			lblbudgetName.TabIndex = 2;
			lblbudgetName.Text = "budget-name";
			// 
			// lvCategories
			// 
			lvCategories.Dock = DockStyle.Fill;
			lvCategories.Location = new Point(0, 0);
			lvCategories.Name = "lvCategories";
			lvCategories.Size = new Size(395, 652);
			lvCategories.TabIndex = 3;
			lvCategories.UseCompatibleStateImageBehavior = false;
			lvCategories.View = View.List;
			lvCategories.SelectedIndexChanged += lvCategories_SelectedIndexChanged;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Location = new Point(12, 74);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(gridPayments);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(lvCategories);
			splitContainer1.Size = new Size(1248, 652);
			splitContainer1.SplitterDistance = 849;
			splitContainer1.TabIndex = 4;
			// 
			// cbWholeMonth
			// 
			cbWholeMonth.AutoSize = true;
			cbWholeMonth.Location = new Point(276, 42);
			cbWholeMonth.Name = "cbWholeMonth";
			cbWholeMonth.Size = new Size(124, 25);
			cbWholeMonth.TabIndex = 5;
			cbWholeMonth.Text = "Whole month";
			cbWholeMonth.UseVisualStyleBackColor = true;
			// 
			// btnAllCategories
			// 
			btnAllCategories.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnAllCategories.Location = new Point(1203, 29);
			btnAllCategories.Name = "btnAllCategories";
			btnAllCategories.Size = new Size(57, 39);
			btnAllCategories.TabIndex = 6;
			btnAllCategories.Text = "*";
			btnAllCategories.UseVisualStyleBackColor = true;
			btnAllCategories.Click += btnAllCategories_Click;
			// 
			// PaymentsForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1272, 738);
			Controls.Add(btnAllCategories);
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
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
		private BindingSource paymentBindingSource;
		private Button btnAllCategories;
	}
}