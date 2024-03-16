namespace DrCost2.CashReceipts
{
	partial class CashReceiptPaymentInputForm
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
			numberCount = new NumericUpDown();
			numberPrice = new NumericUpDown();
			textPaymentSample = new TextBox();
			label3 = new Label();
			btnSelectPaymentSampe = new Button();
			label2 = new Label();
			label1 = new Label();
			btnCreate = new Button();
			cbBudgets = new ComboBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)numberCount).BeginInit();
			((System.ComponentModel.ISupportInitialize)numberPrice).BeginInit();
			SuspendLayout();
			// 
			// numberCount
			// 
			numberCount.DecimalPlaces = 2;
			numberCount.Location = new Point(170, 136);
			numberCount.Margin = new Padding(4);
			numberCount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
			numberCount.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
			numberCount.Name = "numberCount";
			numberCount.Size = new Size(620, 34);
			numberCount.TabIndex = 11;
			numberCount.Tag = "";
			numberCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// numberPrice
			// 
			numberPrice.DecimalPlaces = 2;
			numberPrice.Location = new Point(170, 84);
			numberPrice.Margin = new Padding(4);
			numberPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
			numberPrice.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
			numberPrice.Name = "numberPrice";
			numberPrice.Size = new Size(620, 34);
			numberPrice.TabIndex = 10;
			numberPrice.Tag = "";
			// 
			// textPaymentSample
			// 
			textPaymentSample.Enabled = false;
			textPaymentSample.Location = new Point(170, 16);
			textPaymentSample.Margin = new Padding(4);
			textPaymentSample.Name = "textPaymentSample";
			textPaymentSample.ReadOnly = true;
			textPaymentSample.Size = new Size(568, 34);
			textPaymentSample.TabIndex = 17;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 16);
			label3.Name = "label3";
			label3.Size = new Size(151, 28);
			label3.TabIndex = 16;
			label3.Text = "Наименование";
			// 
			// btnSelectPaymentSampe
			// 
			btnSelectPaymentSampe.Location = new Point(746, 16);
			btnSelectPaymentSampe.Margin = new Padding(4);
			btnSelectPaymentSampe.Name = "btnSelectPaymentSampe";
			btnSelectPaymentSampe.Size = new Size(44, 36);
			btnSelectPaymentSampe.TabIndex = 15;
			btnSelectPaymentSampe.Text = "...";
			btnSelectPaymentSampe.UseVisualStyleBackColor = true;
			btnSelectPaymentSampe.Click += btnSelectPaymentSampe_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 138);
			label2.Name = "label2";
			label2.Size = new Size(120, 28);
			label2.TabIndex = 14;
			label2.Text = "Количество";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 86);
			label1.Name = "label1";
			label1.Size = new Size(109, 28);
			label1.TabIndex = 12;
			label1.Text = "Стоимость";
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.SpringGreen;
			btnCreate.FlatStyle = FlatStyle.Flat;
			btnCreate.Location = new Point(673, 251);
			btnCreate.Margin = new Padding(4);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(117, 64);
			btnCreate.TabIndex = 13;
			btnCreate.Text = "создать";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// cbBudgets
			// 
			cbBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
			cbBudgets.FormattingEnabled = true;
			cbBudgets.Location = new Point(170, 193);
			cbBudgets.Name = "cbBudgets";
			cbBudgets.Size = new Size(620, 36);
			cbBudgets.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(15, 196);
			label4.Name = "label4";
			label4.Size = new Size(83, 28);
			label4.TabIndex = 20;
			label4.Text = "Бюджет";
			// 
			// CashReceiptPaymentInputForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(804, 331);
			Controls.Add(label4);
			Controls.Add(cbBudgets);
			Controls.Add(numberCount);
			Controls.Add(numberPrice);
			Controls.Add(textPaymentSample);
			Controls.Add(label3);
			Controls.Add(btnSelectPaymentSampe);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCreate);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(4);
			Name = "CashReceiptPaymentInputForm";
			Text = "Создание пункта платежа чека";
			FormClosing += CashReceiptPaymentInputForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)numberCount).EndInit();
			((System.ComponentModel.ISupportInitialize)numberPrice).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private NumericUpDown numberCount;
		private NumericUpDown numberPrice;
		private TextBox textPaymentSample;
		private Label label3;
		private Button btnSelectPaymentSampe;
		private Label label2;
		private Label label1;
		private Button btnCreate;
		private ComboBox cbBudgets;
		private Label label4;
	}
}