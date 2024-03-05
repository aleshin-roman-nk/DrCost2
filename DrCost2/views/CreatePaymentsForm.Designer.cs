namespace DrCost2.views
{
	partial class CreatePaymentsForm
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
			dateTimePicker1 = new DateTimePicker();
			gridPayments = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			enteredPaymentDtoBindingSource = new BindingSource(components);
			btnAddPayment = new Button();
			btnCreateAndClose = new Button();
			((System.ComponentModel.ISupportInitialize)gridPayments).BeginInit();
			((System.ComponentModel.ISupportInitialize)enteredPaymentDtoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(13, 13);
			dateTimePicker1.Margin = new Padding(4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(342, 29);
			dateTimePicker1.TabIndex = 0;
			// 
			// gridPayments
			// 
			gridPayments.AllowUserToAddRows = false;
			gridPayments.AllowUserToDeleteRows = false;
			gridPayments.AllowUserToResizeRows = false;
			gridPayments.AutoGenerateColumns = false;
			gridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridPayments.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn });
			gridPayments.DataSource = enteredPaymentDtoBindingSource;
			gridPayments.Location = new Point(13, 62);
			gridPayments.Name = "gridPayments";
			gridPayments.ReadOnly = true;
			gridPayments.RowHeadersWidth = 51;
			gridPayments.RowTemplate.Height = 29;
			gridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridPayments.Size = new Size(1098, 450);
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
			// categoryDataGridViewTextBoxColumn
			// 
			categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
			categoryDataGridViewTextBoxColumn.HeaderText = "category";
			categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			categoryDataGridViewTextBoxColumn.ReadOnly = true;
			categoryDataGridViewTextBoxColumn.Width = 150;
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
			// dateTimeDataGridViewTextBoxColumn
			// 
			dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
			dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
			dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
			dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enteredPaymentDtoBindingSource
			// 
			enteredPaymentDtoBindingSource.DataSource = typeof(Dto.EnteredPaymentDto);
			// 
			// btnAddPayment
			// 
			btnAddPayment.Location = new Point(1058, 8);
			btnAddPayment.Name = "btnAddPayment";
			btnAddPayment.Size = new Size(53, 48);
			btnAddPayment.TabIndex = 2;
			btnAddPayment.Text = "+";
			btnAddPayment.UseVisualStyleBackColor = true;
			btnAddPayment.Click += btnAddPayment_Click;
			// 
			// btnCreateAndClose
			// 
			btnCreateAndClose.Location = new Point(897, 8);
			btnCreateAndClose.Name = "btnCreateAndClose";
			btnCreateAndClose.Size = new Size(155, 48);
			btnCreateAndClose.TabIndex = 3;
			btnCreateAndClose.Text = "Create and close";
			btnCreateAndClose.UseVisualStyleBackColor = true;
			btnCreateAndClose.Click += btnCreateAndClose_Click;
			// 
			// CreatePaymentsForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1123, 524);
			Controls.Add(btnCreateAndClose);
			Controls.Add(btnAddPayment);
			Controls.Add(gridPayments);
			Controls.Add(dateTimePicker1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "CreatePaymentsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CreatePaymentsForm";
			((System.ComponentModel.ISupportInitialize)gridPayments).EndInit();
			((System.ComponentModel.ISupportInitialize)enteredPaymentDtoBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private DataGridView gridPayments;
		private Button btnAddPayment;
		private BindingSource enteredPaymentDtoBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
		private Button btnCreateAndClose;
	}
}