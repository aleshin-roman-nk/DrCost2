namespace DrCost2.views
{
	partial class SpendsOnCategoriesForm
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
			dataGridView1 = new DataGridView();
			componedDtoBindingSource = new BindingSource(components);
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			label1 = new Label();
			lblTotal = new Label();
			categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			summDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)componedDtoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { categoryNameDataGridViewTextBoxColumn, summDataGridViewTextBoxColumn });
			dataGridView1.DataSource = componedDtoBindingSource;
			dataGridView1.Location = new Point(12, 52);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1076, 566);
			dataGridView1.TabIndex = 0;
			// 
			// componedDtoBindingSource
			// 
			componedDtoBindingSource.DataSource = typeof(Dto.ComponedDto);
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 1;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(268, 12);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(250, 34);
			dateTimePicker2.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(524, 17);
			label1.Name = "label1";
			label1.Size = new Size(69, 28);
			label1.TabIndex = 3;
			label1.Text = "сумма";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Location = new Point(599, 17);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(23, 28);
			lblTotal.TabIndex = 4;
			lblTotal.Text = "0";
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			categoryNameDataGridViewTextBoxColumn.HeaderText = "CAT";
			categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			categoryNameDataGridViewTextBoxColumn.Width = 450;
			// 
			// summDataGridViewTextBoxColumn
			// 
			summDataGridViewTextBoxColumn.DataPropertyName = "summ";
			summDataGridViewTextBoxColumn.HeaderText = "summ";
			summDataGridViewTextBoxColumn.MinimumWidth = 6;
			summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
			summDataGridViewTextBoxColumn.ReadOnly = true;
			summDataGridViewTextBoxColumn.Width = 200;
			// 
			// SpendsOnCategoriesForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 630);
			Controls.Add(lblTotal);
			Controls.Add(label1);
			Controls.Add(dateTimePicker2);
			Controls.Add(dateTimePicker1);
			Controls.Add(dataGridView1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "SpendsOnCategoriesForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "SpendsOnCategoriesForm";
			Activated += SpendsOnCategoriesForm_Activated;
			FormClosing += SpendsOnCategoriesForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)componedDtoBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private BindingSource componedDtoBindingSource;
		private Label label1;
		private Label lblTotal;
		private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
	}
}