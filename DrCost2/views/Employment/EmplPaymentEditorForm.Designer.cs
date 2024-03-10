namespace DrCost2.views.Employment
{
	partial class EmplPaymentEditorForm
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
			btnOk = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtDescription = new TextBox();
			numPaymentPrice = new NumericUpDown();
			numPaymentAmount = new NumericUpDown();
			lblPaymentName = new Label();
			lblPaymentTotal = new Label();
			lblTag = new Label();
			((System.ComponentModel.ISupportInitialize)numPaymentPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)numPaymentAmount).BeginInit();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnOk.Location = new Point(497, 453);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(133, 58);
			btnOk.TabIndex = 0;
			btnOk.Text = "Сохранить";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(151, 28);
			label1.TabIndex = 2;
			label1.Text = "Наименование";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 50);
			label2.Name = "label2";
			label2.Size = new Size(109, 28);
			label2.TabIndex = 3;
			label2.Text = "Стоимость";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 96);
			label3.Name = "label3";
			label3.Size = new Size(120, 28);
			label3.TabIndex = 4;
			label3.Text = "Количество";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 194);
			label4.Name = "label4";
			label4.Size = new Size(40, 28);
			label4.TabIndex = 5;
			label4.Text = "Тег";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 143);
			label5.Name = "label5";
			label5.Size = new Size(72, 28);
			label5.TabIndex = 6;
			label5.Text = "Сумма";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 260);
			label6.Name = "label6";
			label6.Size = new Size(104, 28);
			label6.TabIndex = 7;
			label6.Text = "Описание";
			// 
			// txtDescription
			// 
			txtDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtDescription.Location = new Point(12, 293);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(618, 154);
			txtDescription.TabIndex = 8;
			// 
			// numPaymentPrice
			// 
			numPaymentPrice.Location = new Point(171, 48);
			numPaymentPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
			numPaymentPrice.Name = "numPaymentPrice";
			numPaymentPrice.Size = new Size(459, 34);
			numPaymentPrice.TabIndex = 9;
			numPaymentPrice.ThousandsSeparator = true;
			// 
			// numPaymentAmount
			// 
			numPaymentAmount.DecimalPlaces = 2;
			numPaymentAmount.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
			numPaymentAmount.Location = new Point(171, 94);
			numPaymentAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
			numPaymentAmount.Name = "numPaymentAmount";
			numPaymentAmount.Size = new Size(459, 34);
			numPaymentAmount.TabIndex = 10;
			numPaymentAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// lblPaymentName
			// 
			lblPaymentName.AutoSize = true;
			lblPaymentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblPaymentName.Location = new Point(169, 9);
			lblPaymentName.Name = "lblPaymentName";
			lblPaymentName.Size = new Size(154, 28);
			lblPaymentName.TabIndex = 11;
			lblPaymentName.Text = "payment-name";
			// 
			// lblPaymentTotal
			// 
			lblPaymentTotal.AutoSize = true;
			lblPaymentTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblPaymentTotal.Location = new Point(171, 143);
			lblPaymentTotal.Name = "lblPaymentTotal";
			lblPaymentTotal.Size = new Size(147, 28);
			lblPaymentTotal.TabIndex = 12;
			lblPaymentTotal.Text = "payment-total";
			// 
			// lblTag
			// 
			lblTag.AutoSize = true;
			lblTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblTag.Location = new Point(169, 194);
			lblTag.Name = "lblTag";
			lblTag.Size = new Size(133, 28);
			lblTag.TabIndex = 13;
			lblTag.Text = "payment-tag";
			// 
			// EmplPaymentEditorForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(642, 523);
			Controls.Add(lblTag);
			Controls.Add(lblPaymentTotal);
			Controls.Add(lblPaymentName);
			Controls.Add(numPaymentAmount);
			Controls.Add(numPaymentPrice);
			Controls.Add(txtDescription);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnOk);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "EmplPaymentEditorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Правка экземпляра платежа";
			FormClosing += EmplPaymentEditorForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)numPaymentPrice).EndInit();
			((System.ComponentModel.ISupportInitialize)numPaymentAmount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOk;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtDescription;
		private NumericUpDown numPaymentPrice;
		private NumericUpDown numPaymentAmount;
		private Label lblPaymentName;
		private Label lblPaymentTotal;
		private Label lblTag;
	}
}