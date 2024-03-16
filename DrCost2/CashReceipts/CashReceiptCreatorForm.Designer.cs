namespace DrCost2.CashReceipts
{
	partial class CashReceiptCreatorForm
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
			dataGridViewPayments = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			budgetNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			enteredCashReceiptPaymentDtoBindingSource = new BindingSource(components);
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			lblSum = new Label();
			btnAddPayment = new Button();
			btnSave = new Button();
			label2 = new Label();
			txtShop = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
			((System.ComponentModel.ISupportInitialize)enteredCashReceiptPaymentDtoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewPayments
			// 
			dataGridViewPayments.AllowUserToAddRows = false;
			dataGridViewPayments.AllowUserToDeleteRows = false;
			dataGridViewPayments.AllowUserToResizeRows = false;
			dataGridViewPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridViewPayments.AutoGenerateColumns = false;
			dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPayments.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, budgetNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn });
			dataGridViewPayments.DataSource = enteredCashReceiptPaymentDtoBindingSource;
			dataGridViewPayments.Location = new Point(12, 100);
			dataGridViewPayments.Name = "dataGridViewPayments";
			dataGridViewPayments.ReadOnly = true;
			dataGridViewPayments.RowHeadersVisible = false;
			dataGridViewPayments.RowHeadersWidth = 51;
			dataGridViewPayments.RowTemplate.Height = 29;
			dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewPayments.Size = new Size(997, 533);
			dataGridViewPayments.TabIndex = 0;
			dataGridViewPayments.KeyDown += dataGridViewPayments_KeyDown;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn.HeaderText = "name";
			nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.ReadOnly = true;
			nameDataGridViewTextBoxColumn.Width = 300;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
			categoryDataGridViewTextBoxColumn.HeaderText = "category";
			categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
			categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			categoryDataGridViewTextBoxColumn.ReadOnly = true;
			categoryDataGridViewTextBoxColumn.Width = 125;
			// 
			// budgetNameDataGridViewTextBoxColumn
			// 
			budgetNameDataGridViewTextBoxColumn.DataPropertyName = "budgetName";
			budgetNameDataGridViewTextBoxColumn.HeaderText = "budgetName";
			budgetNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			budgetNameDataGridViewTextBoxColumn.Name = "budgetNameDataGridViewTextBoxColumn";
			budgetNameDataGridViewTextBoxColumn.ReadOnly = true;
			budgetNameDataGridViewTextBoxColumn.Width = 125;
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
			// sumDataGridViewTextBoxColumn
			// 
			sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
			sumDataGridViewTextBoxColumn.HeaderText = "sum";
			sumDataGridViewTextBoxColumn.MinimumWidth = 6;
			sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
			sumDataGridViewTextBoxColumn.ReadOnly = true;
			sumDataGridViewTextBoxColumn.Width = 125;
			// 
			// enteredCashReceiptPaymentDtoBindingSource
			// 
			enteredCashReceiptPaymentDtoBindingSource.DataSource = typeof(EnteredCashReceiptPaymentDto);
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 60);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(280, 65);
			label1.Name = "label1";
			label1.Size = new Size(67, 28);
			label1.TabIndex = 2;
			label1.Text = "Итого";
			// 
			// lblSum
			// 
			lblSum.AutoSize = true;
			lblSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSum.Location = new Point(353, 66);
			lblSum.Name = "lblSum";
			lblSum.Size = new Size(78, 28);
			lblSum.TabIndex = 3;
			lblSum.Text = "16 000";
			// 
			// btnAddPayment
			// 
			btnAddPayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddPayment.Location = new Point(947, 12);
			btnAddPayment.Name = "btnAddPayment";
			btnAddPayment.Size = new Size(62, 53);
			btnAddPayment.TabIndex = 4;
			btnAddPayment.Text = "+";
			btnAddPayment.UseVisualStyleBackColor = true;
			btnAddPayment.Click += btnAddPayment_Click;
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSave.Location = new Point(705, 13);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(236, 53);
			btnSave.TabIndex = 5;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 13);
			label2.Name = "label2";
			label2.Size = new Size(104, 28);
			label2.TabIndex = 6;
			label2.Text = "Продавец";
			// 
			// txtShop
			// 
			txtShop.Location = new Point(122, 10);
			txtShop.Name = "txtShop";
			txtShop.Size = new Size(446, 34);
			txtShop.TabIndex = 7;
			// 
			// CashReceiptCreatorForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1021, 657);
			Controls.Add(txtShop);
			Controls.Add(label2);
			Controls.Add(btnSave);
			Controls.Add(btnAddPayment);
			Controls.Add(lblSum);
			Controls.Add(label1);
			Controls.Add(dateTimePicker1);
			Controls.Add(dataGridViewPayments);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "CashReceiptCreatorForm";
			Text = "Чек, документ";
			FormClosing += CashReceiptCreatorForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
			((System.ComponentModel.ISupportInitialize)enteredCashReceiptPaymentDtoBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewPayments;
		private DateTimePicker dateTimePicker1;
		private Label label1;
		private Label lblSum;
		private Button btnAddPayment;
		private Button btnSave;
		private BindingSource enteredCashReceiptPaymentDtoBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn budgetNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
		private Label label2;
		private TextBox txtShop;
	}
}