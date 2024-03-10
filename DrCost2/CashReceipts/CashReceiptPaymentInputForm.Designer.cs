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
			dateTimePicker1 = new DateTimePicker();
			numberCount = new NumericUpDown();
			numberPrice = new NumericUpDown();
			textProductName = new TextBox();
			label3 = new Label();
			btnSelectType = new Button();
			label2 = new Label();
			label1 = new Label();
			btnCreate = new Button();
			comboBox1 = new ComboBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)numberCount).BeginInit();
			((System.ComponentModel.ISupportInitialize)numberPrice).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(15, 12);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 34);
			dateTimePicker1.TabIndex = 18;
			// 
			// numberCount
			// 
			numberCount.DecimalPlaces = 2;
			numberCount.Location = new Point(170, 168);
			numberCount.Margin = new Padding(4, 4, 4, 4);
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
			numberPrice.Location = new Point(170, 116);
			numberPrice.Margin = new Padding(4, 4, 4, 4);
			numberPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
			numberPrice.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
			numberPrice.Name = "numberPrice";
			numberPrice.Size = new Size(620, 34);
			numberPrice.TabIndex = 10;
			numberPrice.Tag = "";
			// 
			// textProductName
			// 
			textProductName.Enabled = false;
			textProductName.Location = new Point(170, 63);
			textProductName.Margin = new Padding(4);
			textProductName.Name = "textProductName";
			textProductName.ReadOnly = true;
			textProductName.Size = new Size(568, 34);
			textProductName.TabIndex = 17;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 63);
			label3.Name = "label3";
			label3.Size = new Size(151, 28);
			label3.TabIndex = 16;
			label3.Text = "Наименование";
			// 
			// btnSelectType
			// 
			btnSelectType.Location = new Point(746, 63);
			btnSelectType.Margin = new Padding(4);
			btnSelectType.Name = "btnSelectType";
			btnSelectType.Size = new Size(44, 36);
			btnSelectType.TabIndex = 15;
			btnSelectType.Text = "...";
			btnSelectType.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 170);
			label2.Name = "label2";
			label2.Size = new Size(120, 28);
			label2.TabIndex = 14;
			label2.Text = "Количество";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 118);
			label1.Name = "label1";
			label1.Size = new Size(109, 28);
			label1.TabIndex = 12;
			label1.Text = "Стоимость";
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.SpringGreen;
			btnCreate.FlatStyle = FlatStyle.Flat;
			btnCreate.Location = new Point(673, 283);
			btnCreate.Margin = new Padding(4);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(117, 64);
			btnCreate.TabIndex = 13;
			btnCreate.Text = "создать";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(170, 225);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(620, 36);
			comboBox1.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(15, 228);
			label4.Name = "label4";
			label4.Size = new Size(83, 28);
			label4.TabIndex = 20;
			label4.Text = "Бюджет";
			// 
			// CashReceiptPaymentInputForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(804, 360);
			Controls.Add(label4);
			Controls.Add(comboBox1);
			Controls.Add(dateTimePicker1);
			Controls.Add(numberCount);
			Controls.Add(numberPrice);
			Controls.Add(textProductName);
			Controls.Add(label3);
			Controls.Add(btnSelectType);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCreate);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(4, 4, 4, 4);
			Name = "CashReceiptPaymentInputForm";
			Text = "Создание пункта платежа чека";
			((System.ComponentModel.ISupportInitialize)numberCount).EndInit();
			((System.ComponentModel.ISupportInitialize)numberPrice).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private NumericUpDown numberCount;
		private NumericUpDown numberPrice;
		private TextBox textProductName;
		private Label label3;
		private Button btnSelectType;
		private Label label2;
		private Label label1;
		private Button btnCreate;
		private ComboBox comboBox1;
		private Label label4;
	}
}