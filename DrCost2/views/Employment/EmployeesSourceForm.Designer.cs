namespace DrCost2.views.Employment
{
	partial class EmployeesSourceForm
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
			gridEmployeesSource = new DataGridView();
			btnNewEmployee = new Button();
			((System.ComponentModel.ISupportInitialize)gridEmployeesSource).BeginInit();
			SuspendLayout();
			// 
			// gridEmployeesSource
			// 
			gridEmployeesSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gridEmployeesSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridEmployeesSource.Location = new Point(16, 66);
			gridEmployeesSource.Margin = new Padding(4, 4, 4, 4);
			gridEmployeesSource.Name = "gridEmployeesSource";
			gridEmployeesSource.RowHeadersWidth = 51;
			gridEmployeesSource.RowTemplate.Height = 29;
			gridEmployeesSource.Size = new Size(891, 547);
			gridEmployeesSource.TabIndex = 0;
			// 
			// btnNewEmployee
			// 
			btnNewEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnNewEmployee.Location = new Point(805, 13);
			btnNewEmployee.Margin = new Padding(4, 4, 4, 4);
			btnNewEmployee.Name = "btnNewEmployee";
			btnNewEmployee.Size = new Size(102, 41);
			btnNewEmployee.TabIndex = 1;
			btnNewEmployee.Text = "новый";
			btnNewEmployee.UseVisualStyleBackColor = true;
			// 
			// EmployeesSourceForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(920, 630);
			Controls.Add(btnNewEmployee);
			Controls.Add(gridEmployeesSource);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			Name = "EmployeesSourceForm";
			Text = "База работников";
			((System.ComponentModel.ISupportInitialize)gridEmployeesSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView gridEmployeesSource;
		private Button btnNewEmployee;
	}
}