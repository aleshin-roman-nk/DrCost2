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
			dataGridViewPayments = new DataGridView();
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			btnAddPayment = new Button();
			btnSave = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewPayments
			// 
			dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPayments.Location = new Point(12, 71);
			dataGridViewPayments.Name = "dataGridViewPayments";
			dataGridViewPayments.RowHeadersWidth = 51;
			dataGridViewPayments.RowTemplate.Height = 29;
			dataGridViewPayments.Size = new Size(997, 459);
			dataGridViewPayments.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 19);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(280, 24);
			label1.Name = "label1";
			label1.Size = new Size(67, 28);
			label1.TabIndex = 2;
			label1.Text = "Итого";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(353, 25);
			label2.Name = "label2";
			label2.Size = new Size(78, 28);
			label2.TabIndex = 3;
			label2.Text = "16 000";
			// 
			// btnAddPayment
			// 
			btnAddPayment.Location = new Point(947, 12);
			btnAddPayment.Name = "btnAddPayment";
			btnAddPayment.Size = new Size(62, 53);
			btnAddPayment.TabIndex = 4;
			btnAddPayment.Text = "+";
			btnAddPayment.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(705, 13);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(236, 53);
			btnSave.TabIndex = 5;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// CashReceiptCreatorForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1021, 542);
			Controls.Add(btnSave);
			Controls.Add(btnAddPayment);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dateTimePicker1);
			Controls.Add(dataGridViewPayments);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			Name = "CashReceiptCreatorForm";
			Text = "Чек, документ";
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewPayments;
		private DateTimePicker dateTimePicker1;
		private Label label1;
		private Label label2;
		private Button btnAddPayment;
		private Button btnSave;
	}
}