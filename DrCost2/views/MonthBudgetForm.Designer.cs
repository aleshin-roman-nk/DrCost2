namespace DrCost2.views
{
	partial class MonthBudgetForm
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
			cbYears = new ComboBox();
			cbMonths = new ComboBox();
			label1 = new Label();
			lblBudgetNoney = new Label();
			lblSpent = new Label();
			label3 = new Label();
			label2 = new Label();
			lblAlowedToTheEnd = new Label();
			textBoxEnterBudget = new TextBox();
			SuspendLayout();
			// 
			// cbYears
			// 
			cbYears.DropDownStyle = ComboBoxStyle.DropDownList;
			cbYears.FormattingEnabled = true;
			cbYears.Location = new Point(12, 12);
			cbYears.Name = "cbYears";
			cbYears.Size = new Size(221, 36);
			cbYears.TabIndex = 0;
			// 
			// cbMonths
			// 
			cbMonths.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMonths.FormattingEnabled = true;
			cbMonths.Location = new Point(239, 12);
			cbMonths.Name = "cbMonths";
			cbMonths.Size = new Size(329, 36);
			cbMonths.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 84);
			label1.Name = "label1";
			label1.Size = new Size(119, 28);
			label1.TabIndex = 2;
			label1.Text = "Бюджет [TL]";
			// 
			// lblBudgetNoney
			// 
			lblBudgetNoney.AutoSize = true;
			lblBudgetNoney.Location = new Point(190, 84);
			lblBudgetNoney.Name = "lblBudgetNoney";
			lblBudgetNoney.Size = new Size(23, 28);
			lblBudgetNoney.TabIndex = 3;
			lblBudgetNoney.Text = "0";
			lblBudgetNoney.Click += lblBudgetNoney_Click;
			// 
			// lblSpent
			// 
			lblSpent.AutoSize = true;
			lblSpent.Location = new Point(190, 140);
			lblSpent.Name = "lblSpent";
			lblSpent.Size = new Size(23, 28);
			lblSpent.TabIndex = 4;
			lblSpent.Text = "0";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 140);
			label3.Name = "label3";
			label3.Size = new Size(124, 28);
			label3.TabIndex = 5;
			label3.Text = "Расходы [TL]";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 196);
			label2.Name = "label2";
			label2.Size = new Size(146, 28);
			label2.TabIndex = 6;
			label2.Text = "Лимит на день";
			// 
			// lblAlowedToTheEnd
			// 
			lblAlowedToTheEnd.AutoSize = true;
			lblAlowedToTheEnd.Location = new Point(190, 196);
			lblAlowedToTheEnd.Name = "lblAlowedToTheEnd";
			lblAlowedToTheEnd.Size = new Size(23, 28);
			lblAlowedToTheEnd.TabIndex = 7;
			lblAlowedToTheEnd.Text = "0";
			// 
			// textBoxEnterBudget
			// 
			textBoxEnterBudget.Location = new Point(190, 81);
			textBoxEnterBudget.Name = "textBoxEnterBudget";
			textBoxEnterBudget.Size = new Size(193, 34);
			textBoxEnterBudget.TabIndex = 8;
			textBoxEnterBudget.Visible = false;
			textBoxEnterBudget.KeyDown += textBoxEnterBudget_KeyDown;
			// 
			// MonthBudgetForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(708, 426);
			Controls.Add(textBoxEnterBudget);
			Controls.Add(lblAlowedToTheEnd);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(lblSpent);
			Controls.Add(lblBudgetNoney);
			Controls.Add(label1);
			Controls.Add(cbMonths);
			Controls.Add(cbYears);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "MonthBudgetForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Бюджет месяца";
			FormClosing += MonthBudgetForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbYears;
		private ComboBox cbMonths;
		private Label label1;
		private Label lblBudgetNoney;
		private Label lblSpent;
		private Label label3;
		private Label label2;
		private Label lblAlowedToTheEnd;
		private TextBox textBoxEnterBudget;
	}
}