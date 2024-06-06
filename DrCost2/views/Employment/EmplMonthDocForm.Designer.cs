namespace DrCost2.views.Employment
{
	partial class EmplMonthDocForm
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			lblDocName = new Label();
			splitContainer1 = new SplitContainer();
			gridEmployees = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			cashDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			employeeBindingSource = new BindingSource(components);
			panel2 = new Panel();
			gridEmplPayment = new DataGridView();
			nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sumDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			tagNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			emplPaymentBindingSource = new BindingSource(components);
			panel1 = new Panel();
			txtCurrentEmployee = new TextBox();
			lblTotalSum = new Label();
			dateTimePicker1 = new DateTimePicker();
			lblFotTotal = new Label();
			lblOpsTotal = new Label();
			lblKhozTotal = new Label();
			btnAddEmpl = new Button();
			btnCreateDocument = new Button();
			btnAddPayment = new Button();
			btnAddAllEmployees = new Button();
			btnCloneDocumentImage = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridEmployees).BeginInit();
			((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridEmplPayment).BeginInit();
			((System.ComponentModel.ISupportInitialize)emplPaymentBindingSource).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lblDocName
			// 
			lblDocName.AutoSize = true;
			lblDocName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblDocName.Location = new Point(12, 9);
			lblDocName.Name = "lblDocName";
			lblDocName.Size = new Size(102, 25);
			lblDocName.TabIndex = 0;
			lblDocName.Text = "doc-name";
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer1.Location = new Point(12, 114);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(gridEmployees);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(panel2);
			splitContainer1.Panel2.Controls.Add(panel1);
			splitContainer1.Size = new Size(1296, 557);
			splitContainer1.SplitterDistance = 580;
			splitContainer1.TabIndex = 1;
			// 
			// gridEmployees
			// 
			gridEmployees.AllowUserToAddRows = false;
			gridEmployees.AllowUserToDeleteRows = false;
			gridEmployees.AllowUserToResizeRows = false;
			gridEmployees.AutoGenerateColumns = false;
			gridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridEmployees.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, cashDataGridViewCheckBoxColumn });
			gridEmployees.DataSource = employeeBindingSource;
			gridEmployees.Dock = DockStyle.Fill;
			gridEmployees.Location = new Point(0, 0);
			gridEmployees.Name = "gridEmployees";
			gridEmployees.ReadOnly = true;
			gridEmployees.RowHeadersVisible = false;
			gridEmployees.RowHeadersWidth = 51;
			gridEmployees.RowTemplate.Height = 29;
			gridEmployees.SelectionMode = DataGridViewSelectionMode.CellSelect;
			gridEmployees.ShowCellToolTips = false;
			gridEmployees.Size = new Size(580, 557);
			gridEmployees.TabIndex = 0;
			gridEmployees.KeyDown += gridEmployees_KeyDown;
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
			// sumDataGridViewTextBoxColumn
			// 
			sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = null;
			sumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			sumDataGridViewTextBoxColumn.HeaderText = "sum";
			sumDataGridViewTextBoxColumn.MinimumWidth = 6;
			sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
			sumDataGridViewTextBoxColumn.ReadOnly = true;
			sumDataGridViewTextBoxColumn.Width = 150;
			// 
			// cashDataGridViewCheckBoxColumn
			// 
			cashDataGridViewCheckBoxColumn.DataPropertyName = "cash";
			cashDataGridViewCheckBoxColumn.HeaderText = "cash";
			cashDataGridViewCheckBoxColumn.MinimumWidth = 6;
			cashDataGridViewCheckBoxColumn.Name = "cashDataGridViewCheckBoxColumn";
			cashDataGridViewCheckBoxColumn.ReadOnly = true;
			cashDataGridViewCheckBoxColumn.Width = 50;
			// 
			// employeeBindingSource
			// 
			employeeBindingSource.DataSource = typeof(Core.Employment.entity.Employee);
			// 
			// panel2
			// 
			panel2.Controls.Add(gridEmplPayment);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 38);
			panel2.Name = "panel2";
			panel2.Size = new Size(712, 519);
			panel2.TabIndex = 3;
			// 
			// gridEmplPayment
			// 
			gridEmplPayment.AllowUserToAddRows = false;
			gridEmplPayment.AllowUserToDeleteRows = false;
			gridEmplPayment.AllowUserToResizeRows = false;
			gridEmplPayment.AutoGenerateColumns = false;
			gridEmplPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridEmplPayment.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn1, tagNameDataGridViewTextBoxColumn });
			gridEmplPayment.DataSource = emplPaymentBindingSource;
			gridEmplPayment.Dock = DockStyle.Fill;
			gridEmplPayment.Location = new Point(0, 0);
			gridEmplPayment.Name = "gridEmplPayment";
			gridEmplPayment.ReadOnly = true;
			gridEmplPayment.RowHeadersVisible = false;
			gridEmplPayment.RowHeadersWidth = 51;
			gridEmplPayment.RowTemplate.Height = 29;
			gridEmplPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridEmplPayment.ShowCellToolTips = false;
			gridEmplPayment.Size = new Size(712, 519);
			gridEmplPayment.TabIndex = 0;
			gridEmplPayment.CellMouseDoubleClick += gridEmplPayment_CellMouseDoubleClick;
			gridEmplPayment.KeyDown += gridEmplPayment_KeyDown;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
			nameDataGridViewTextBoxColumn1.HeaderText = "name";
			nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
			nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			nameDataGridViewTextBoxColumn1.ReadOnly = true;
			nameDataGridViewTextBoxColumn1.Width = 200;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			priceDataGridViewTextBoxColumn.HeaderText = "price";
			priceDataGridViewTextBoxColumn.MinimumWidth = 6;
			priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			priceDataGridViewTextBoxColumn.ReadOnly = true;
			priceDataGridViewTextBoxColumn.Width = 125;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
			amountDataGridViewTextBoxColumn.HeaderText = "amount";
			amountDataGridViewTextBoxColumn.MinimumWidth = 6;
			amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			amountDataGridViewTextBoxColumn.ReadOnly = true;
			amountDataGridViewTextBoxColumn.Width = 125;
			// 
			// sumDataGridViewTextBoxColumn1
			// 
			sumDataGridViewTextBoxColumn1.DataPropertyName = "sum";
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			sumDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
			sumDataGridViewTextBoxColumn1.HeaderText = "sum";
			sumDataGridViewTextBoxColumn1.MinimumWidth = 6;
			sumDataGridViewTextBoxColumn1.Name = "sumDataGridViewTextBoxColumn1";
			sumDataGridViewTextBoxColumn1.ReadOnly = true;
			sumDataGridViewTextBoxColumn1.Width = 125;
			// 
			// tagNameDataGridViewTextBoxColumn
			// 
			tagNameDataGridViewTextBoxColumn.DataPropertyName = "tagName";
			tagNameDataGridViewTextBoxColumn.HeaderText = "tagName";
			tagNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
			tagNameDataGridViewTextBoxColumn.ReadOnly = true;
			tagNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// emplPaymentBindingSource
			// 
			emplPaymentBindingSource.DataSource = typeof(Core.Employment.entity.EmplPayment);
			// 
			// panel1
			// 
			panel1.Controls.Add(txtCurrentEmployee);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(712, 38);
			panel1.TabIndex = 2;
			// 
			// txtCurrentEmployee
			// 
			txtCurrentEmployee.Dock = DockStyle.Top;
			txtCurrentEmployee.Location = new Point(0, 0);
			txtCurrentEmployee.Name = "txtCurrentEmployee";
			txtCurrentEmployee.ReadOnly = true;
			txtCurrentEmployee.Size = new Size(712, 29);
			txtCurrentEmployee.TabIndex = 1;
			// 
			// lblTotalSum
			// 
			lblTotalSum.AutoSize = true;
			lblTotalSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblTotalSum.Location = new Point(12, 40);
			lblTotalSum.Name = "lblTotalSum";
			lblTotalSum.Size = new Size(98, 25);
			lblTotalSum.TabIndex = 2;
			lblTotalSum.Text = "total-sum";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 74);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 29);
			dateTimePicker1.TabIndex = 3;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// lblFotTotal
			// 
			lblFotTotal.AutoSize = true;
			lblFotTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFotTotal.Location = new Point(268, 77);
			lblFotTotal.Name = "lblFotTotal";
			lblFotTotal.Size = new Size(107, 21);
			lblFotTotal.TabIndex = 4;
			lblFotTotal.Text = "ФОТ: 475 000";
			// 
			// lblOpsTotal
			// 
			lblOpsTotal.AutoSize = true;
			lblOpsTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblOpsTotal.Location = new Point(418, 79);
			lblOpsTotal.Name = "lblOpsTotal";
			lblOpsTotal.Size = new Size(95, 21);
			lblOpsTotal.TabIndex = 5;
			lblOpsTotal.Text = "ОПС: ХХХХХ";
			// 
			// lblKhozTotal
			// 
			lblKhozTotal.AutoSize = true;
			lblKhozTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblKhozTotal.Location = new Point(586, 79);
			lblKhozTotal.Name = "lblKhozTotal";
			lblKhozTotal.Size = new Size(92, 21);
			lblKhozTotal.TabIndex = 6;
			lblKhozTotal.Text = "ХОЗ: ХХХХХ";
			// 
			// btnAddEmpl
			// 
			btnAddEmpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddEmpl.Location = new Point(1093, 12);
			btnAddEmpl.Name = "btnAddEmpl";
			btnAddEmpl.Size = new Size(123, 45);
			btnAddEmpl.TabIndex = 7;
			btnAddEmpl.Text = "+ работник";
			btnAddEmpl.UseVisualStyleBackColor = true;
			btnAddEmpl.Click += btnAddEmpl_Click;
			// 
			// btnCreateDocument
			// 
			btnCreateDocument.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCreateDocument.Location = new Point(775, 12);
			btnCreateDocument.Name = "btnCreateDocument";
			btnCreateDocument.Size = new Size(83, 45);
			btnCreateDocument.TabIndex = 8;
			btnCreateDocument.Text = "+ док";
			btnCreateDocument.UseVisualStyleBackColor = true;
			btnCreateDocument.Click += btnCreateDocument_Click;
			// 
			// btnAddPayment
			// 
			btnAddPayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddPayment.Location = new Point(1222, 12);
			btnAddPayment.Name = "btnAddPayment";
			btnAddPayment.Size = new Size(80, 45);
			btnAddPayment.TabIndex = 9;
			btnAddPayment.Text = "+ плат";
			btnAddPayment.UseVisualStyleBackColor = true;
			btnAddPayment.Click += btnAddPayment_Click;
			// 
			// btnAddAllEmployees
			// 
			btnAddAllEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddAllEmployees.Location = new Point(933, 12);
			btnAddAllEmployees.Name = "btnAddAllEmployees";
			btnAddAllEmployees.Size = new Size(154, 45);
			btnAddAllEmployees.TabIndex = 10;
			btnAddAllEmployees.Text = "+ все работн";
			btnAddAllEmployees.UseVisualStyleBackColor = true;
			btnAddAllEmployees.Click += btnAddAllEmployees_Click;
			// 
			// btnCloneDocumentImage
			// 
			btnCloneDocumentImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCloneDocumentImage.Location = new Point(864, 12);
			btnCloneDocumentImage.Name = "btnCloneDocumentImage";
			btnCloneDocumentImage.Size = new Size(63, 45);
			btnCloneDocumentImage.TabIndex = 11;
			btnCloneDocumentImage.Text = "клон";
			btnCloneDocumentImage.UseVisualStyleBackColor = true;
			btnCloneDocumentImage.Click += btnCloneDocumentImage_Click;
			// 
			// EmplMonthDocForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1314, 683);
			Controls.Add(btnCloneDocumentImage);
			Controls.Add(btnAddAllEmployees);
			Controls.Add(btnAddPayment);
			Controls.Add(btnCreateDocument);
			Controls.Add(btnAddEmpl);
			Controls.Add(lblKhozTotal);
			Controls.Add(lblOpsTotal);
			Controls.Add(lblFotTotal);
			Controls.Add(dateTimePicker1);
			Controls.Add(lblTotalSum);
			Controls.Add(splitContainer1);
			Controls.Add(lblDocName);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "EmplMonthDocForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Месячный табель";
			FormClosing += EmploymentDocForm_FormClosing;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridEmployees).EndInit();
			((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridEmplPayment).EndInit();
			((System.ComponentModel.ISupportInitialize)emplPaymentBindingSource).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDocName;
		private SplitContainer splitContainer1;
		private Label lblTotalSum;
		private DateTimePicker dateTimePicker1;
		private Label lblFotTotal;
		private Label lblOpsTotal;
		private Label lblKhozTotal;
		private Button btnAddEmpl;
		private Button btnCreateDocument;
		private Button btnAddPayment;
		private DataGridView gridEmployees;
		private DataGridView gridEmplPayment;
		private BindingSource employeeBindingSource;
		private BindingSource emplPaymentBindingSource;
		private Button btnAddAllEmployees;
		private TextBox txtCurrentEmployee;
		private Panel panel1;
		private Panel panel2;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn cashDataGridViewCheckBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
		private Button btnCloneDocumentImage;
	}
}