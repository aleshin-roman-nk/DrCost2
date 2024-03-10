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
			dateTimePicker1 = new DateTimePicker();
			splitContainer1 = new SplitContainer();
			listViewCashReceipt = new ListView();
			dataGridViewPayments = new DataGridView();
			cbWholeMonth = new CheckBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 0;
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(12, 74);
			splitContainer1.Margin = new Padding(4, 4, 4, 4);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(listViewCashReceipt);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(dataGridViewPayments);
			splitContainer1.Size = new Size(1142, 468);
			splitContainer1.SplitterDistance = 380;
			splitContainer1.SplitterWidth = 6;
			splitContainer1.TabIndex = 1;
			// 
			// listViewCashReceipt
			// 
			listViewCashReceipt.Dock = DockStyle.Fill;
			listViewCashReceipt.Location = new Point(0, 0);
			listViewCashReceipt.Name = "listViewCashReceipt";
			listViewCashReceipt.Size = new Size(380, 468);
			listViewCashReceipt.TabIndex = 0;
			listViewCashReceipt.UseCompatibleStateImageBehavior = false;
			// 
			// dataGridViewPayments
			// 
			dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPayments.Dock = DockStyle.Fill;
			dataGridViewPayments.Location = new Point(0, 0);
			dataGridViewPayments.Name = "dataGridViewPayments";
			dataGridViewPayments.RowHeadersWidth = 51;
			dataGridViewPayments.RowTemplate.Height = 29;
			dataGridViewPayments.Size = new Size(756, 468);
			dataGridViewPayments.TabIndex = 0;
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
			// 
			// button1
			// 
			button1.Location = new Point(1088, 12);
			button1.Name = "button1";
			button1.Size = new Size(66, 55);
			button1.TabIndex = 7;
			button1.Text = "+";
			button1.UseVisualStyleBackColor = true;
			// 
			// CashReceiptsMainForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1166, 555);
			Controls.Add(button1);
			Controls.Add(cbWholeMonth);
			Controls.Add(splitContainer1);
			Controls.Add(dateTimePicker1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			Name = "CashReceiptsMainForm";
			Text = "Чеки, документы";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private SplitContainer splitContainer1;
		private ListView listViewCashReceipt;
		private DataGridView dataGridViewPayments;
		private CheckBox cbWholeMonth;
		private Button button1;
	}
}