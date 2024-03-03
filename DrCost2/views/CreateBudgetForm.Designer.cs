namespace DrCost2.views
{
	partial class CreateBudgetForm
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
			txtBudgetName = new TextBox();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// txtBudgetName
			// 
			txtBudgetName.Location = new Point(13, 53);
			txtBudgetName.Margin = new Padding(4);
			txtBudgetName.Name = "txtBudgetName";
			txtBudgetName.Size = new Size(485, 34);
			txtBudgetName.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 21);
			label1.Name = "label1";
			label1.Size = new Size(263, 28);
			label1.TabIndex = 1;
			label1.Text = "Введите название бюджета";
			// 
			// button1
			// 
			button1.Location = new Point(342, 94);
			button1.Name = "button1";
			button1.Size = new Size(156, 53);
			button1.TabIndex = 2;
			button1.Text = "Создать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// CreateBudgetForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(510, 158);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(txtBudgetName);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "CreateBudgetForm";
			Text = "CreateBudgetForm";
			FormClosing += CreateBudgetForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBudgetName;
		private Label label1;
		private Button button1;
	}
}