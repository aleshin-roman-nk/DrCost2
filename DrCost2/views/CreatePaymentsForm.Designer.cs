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
			dateTimePicker1 = new DateTimePicker();
			gridPayments = new DataGridView();
			btnAddPayment = new Button();
			((System.ComponentModel.ISupportInitialize)gridPayments).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(13, 13);
			dateTimePicker1.Margin = new Padding(4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(342, 34);
			dateTimePicker1.TabIndex = 0;
			// 
			// gridPayments
			// 
			gridPayments.AllowUserToAddRows = false;
			gridPayments.AllowUserToDeleteRows = false;
			gridPayments.AllowUserToResizeRows = false;
			gridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridPayments.Location = new Point(13, 62);
			gridPayments.Name = "gridPayments";
			gridPayments.ReadOnly = true;
			gridPayments.RowHeadersWidth = 51;
			gridPayments.RowTemplate.Height = 29;
			gridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridPayments.Size = new Size(1098, 450);
			gridPayments.TabIndex = 1;
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
			// CreatePaymentsForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1123, 524);
			Controls.Add(btnAddPayment);
			Controls.Add(gridPayments);
			Controls.Add(dateTimePicker1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "CreatePaymentsForm";
			Text = "CreatePaymentsForm";
			((System.ComponentModel.ISupportInitialize)gridPayments).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private DataGridView gridPayments;
		private Button btnAddPayment;
	}
}