namespace DrCost2.CashReceipts
{
	partial class CashReceiptsMainForm
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
			dateTimePicker1 = new DateTimePicker();
			splitContainer1 = new SplitContainer();
			listViewCashReceipt = new ListView();
			dataGridViewPayments = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			paymentBindingSource = new BindingSource(components);
			cbWholeMonth = new CheckBox();
			btnAddCashReceipt = new Button();
			lblCashReceiptTitle = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
			((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 0;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Location = new Point(12, 98);
			splitContainer1.Margin = new Padding(4);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(listViewCashReceipt);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(dataGridViewPayments);
			splitContainer1.Size = new Size(1120, 444);
			splitContainer1.SplitterDistance = 269;
			splitContainer1.SplitterWidth = 6;
			splitContainer1.TabIndex = 1;
			// 
			// listViewCashReceipt
			// 
			listViewCashReceipt.Dock = DockStyle.Fill;
			listViewCashReceipt.Location = new Point(0, 0);
			listViewCashReceipt.Name = "listViewCashReceipt";
			listViewCashReceipt.Size = new Size(269, 444);
			listViewCashReceipt.TabIndex = 0;
			listViewCashReceipt.UseCompatibleStateImageBehavior = false;
			listViewCashReceipt.View = View.List;
			listViewCashReceipt.SelectedIndexChanged += listViewCashReceipt_SelectedIndexChanged;
			// 
			// dataGridViewPayments
			// 
			dataGridViewPayments.AllowUserToAddRows = false;
			dataGridViewPayments.AllowUserToDeleteRows = false;
			dataGridViewPayments.AllowUserToResizeRows = false;
			dataGridViewPayments.AutoGenerateColumns = false;
			dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPayments.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn });
			dataGridViewPayments.DataSource = paymentBindingSource;
			dataGridViewPayments.Dock = DockStyle.Fill;
			dataGridViewPayments.Location = new Point(0, 0);
			dataGridViewPayments.Name = "dataGridViewPayments";
			dataGridViewPayments.ReadOnly = true;
			dataGridViewPayments.RowHeadersVisible = false;
			dataGridViewPayments.RowHeadersWidth = 51;
			dataGridViewPayments.RowTemplate.Height = 29;
			dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewPayments.Size = new Size(845, 444);
			dataGridViewPayments.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "name";
			nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 250;
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
			// categoryNameDataGridViewTextBoxColumn
			// 
			categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			categoryNameDataGridViewTextBoxColumn.HeaderText = "categoryName";
			categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			categoryNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// paymentBindingSource
			// 
			paymentBindingSource.DataSource = typeof(Core.entity.Payment);
			// 
			// cbWholeMonth
			// 
			cbWholeMonth.AutoSize = true;
			cbWholeMonth.Checked = true;
			cbWholeMonth.CheckState = CheckState.Checked;
			cbWholeMonth.Location = new Point(268, 14);
			cbWholeMonth.Name = "cbWholeMonth";
			cbWholeMonth.Size = new Size(154, 32);
			cbWholeMonth.TabIndex = 6;
			cbWholeMonth.Text = "Whole month";
			cbWholeMonth.UseVisualStyleBackColor = true;
			cbWholeMonth.CheckedChanged += cbWholeMonth_CheckedChanged;
			// 
			// btnAddCashReceipt
			// 
			btnAddCashReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddCashReceipt.Location = new Point(1066, 14);
			btnAddCashReceipt.Name = "btnAddCashReceipt";
			btnAddCashReceipt.Size = new Size(66, 55);
			btnAddCashReceipt.TabIndex = 7;
			btnAddCashReceipt.Text = "+";
			btnAddCashReceipt.UseVisualStyleBackColor = true;
			btnAddCashReceipt.Click += btnAddCashReceipt_Click;
			// 
			// lblCashReceiptTitle
			// 
			lblCashReceiptTitle.AutoSize = true;
			lblCashReceiptTitle.Location = new Point(12, 58);
			lblCashReceiptTitle.Name = "lblCashReceiptTitle";
			lblCashReceiptTitle.Size = new Size(251, 28);
			lblCashReceiptTitle.TabIndex = 8;
			lblCashReceiptTitle.Text = "06.03.2024; Сумма: 1 560 Р";
			// 
			// CashReceiptsMainForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1144, 550);
			Controls.Add(lblCashReceiptTitle);
			Controls.Add(btnAddCashReceipt);
			Controls.Add(cbWholeMonth);
			Controls.Add(splitContainer1);
			Controls.Add(dateTimePicker1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "CashReceiptsMainForm";
			Text = "Чеки, документы";
			FormClosing += CashReceiptsMainForm_FormClosing;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
			((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private SplitContainer splitContainer1;
		private ListView listViewCashReceipt;
		private DataGridView dataGridViewPayments;
		private CheckBox cbWholeMonth;
		private Button btnAddCashReceipt;
		private Label lblCashReceiptTitle;
		private BindingSource paymentBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
	}
}