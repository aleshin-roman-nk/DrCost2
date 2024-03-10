namespace DrCost2.views.Employment
{
	partial class EmplPaymentSourceSelectorForm
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
			gridEmplPaymentSources = new DataGridView();
			nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			tagNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			emplPaymentSourceBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)gridEmplPaymentSources).BeginInit();
			((System.ComponentModel.ISupportInitialize)emplPaymentSourceBindingSource).BeginInit();
			SuspendLayout();
			// 
			// gridEmplPaymentSources
			// 
			gridEmplPaymentSources.AllowUserToAddRows = false;
			gridEmplPaymentSources.AllowUserToDeleteRows = false;
			gridEmplPaymentSources.AllowUserToResizeRows = false;
			gridEmplPaymentSources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridEmplPaymentSources.AutoGenerateColumns = false;
			gridEmplPaymentSources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridEmplPaymentSources.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, tagNameDataGridViewTextBoxColumn });
			gridEmplPaymentSources.DataSource = emplPaymentSourceBindingSource;
			gridEmplPaymentSources.Location = new Point(12, 12);
			gridEmplPaymentSources.Name = "gridEmplPaymentSources";
			gridEmplPaymentSources.ReadOnly = true;
			gridEmplPaymentSources.RowHeadersVisible = false;
			gridEmplPaymentSources.RowHeadersWidth = 51;
			gridEmplPaymentSources.RowTemplate.Height = 29;
			gridEmplPaymentSources.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridEmplPaymentSources.ShowCellToolTips = false;
			gridEmplPaymentSources.Size = new Size(790, 606);
			gridEmplPaymentSources.TabIndex = 0;
			gridEmplPaymentSources.KeyDown += gridEmplPaymentSources_KeyDown;
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
			priceDataGridViewTextBoxColumn.Width = 250;
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
			// emplPaymentSourceBindingSource
			// 
			emplPaymentSourceBindingSource.DataSource = typeof(Core.Employment.entity.EmplPaymentSource);
			// 
			// EmplPaymentSourceSelectorForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(814, 630);
			Controls.Add(gridEmplPaymentSources);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "EmplPaymentSourceSelectorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "База платежных пунктов";
			FormClosing += EmplPaymentSourceSelectorForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)gridEmplPaymentSources).EndInit();
			((System.ComponentModel.ISupportInitialize)emplPaymentSourceBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView gridEmplPaymentSources;
		private BindingSource emplPaymentSourceBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
	}
}