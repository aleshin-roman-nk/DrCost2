﻿namespace DrCost2.views
{
	partial class CreatePaymentSampleForm
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
			cbCategory = new ComboBox();
			textProductName = new TextBox();
			cbFindingTag = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnAccept = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// cbCategory
			// 
			cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCategory.FormattingEnabled = true;
			cbCategory.Location = new Point(12, 128);
			cbCategory.Name = "cbCategory";
			cbCategory.Size = new Size(406, 29);
			cbCategory.TabIndex = 0;
			// 
			// textProductName
			// 
			textProductName.Location = new Point(12, 40);
			textProductName.Name = "textProductName";
			textProductName.Size = new Size(406, 29);
			textProductName.TabIndex = 1;
			// 
			// cbFindingTag
			// 
			cbFindingTag.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFindingTag.FormattingEnabled = true;
			cbFindingTag.Location = new Point(12, 226);
			cbFindingTag.Name = "cbFindingTag";
			cbFindingTag.Size = new Size(406, 29);
			cbFindingTag.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(117, 21);
			label1.TabIndex = 3;
			label1.Text = "Наименование";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(12, 97);
			label2.Name = "label2";
			label2.Size = new Size(107, 21);
			label2.TabIndex = 4;
			label2.Text = "Категория *";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 195);
			label3.Name = "label3";
			label3.Size = new Size(115, 21);
			label3.TabIndex = 5;
			label3.Text = "Тег для поиска";
			// 
			// btnAccept
			// 
			btnAccept.Location = new Point(12, 295);
			btnAccept.Name = "btnAccept";
			btnAccept.Size = new Size(151, 56);
			btnAccept.TabIndex = 6;
			btnAccept.Text = "Сохранить";
			btnAccept.UseVisualStyleBackColor = true;
			btnAccept.Click += btnAccept_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(267, 295);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(151, 56);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Отмена";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// CreatePaymentSampleForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(432, 378);
			Controls.Add(btnCancel);
			Controls.Add(btnAccept);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cbFindingTag);
			Controls.Add(textProductName);
			Controls.Add(cbCategory);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(4);
			MaximizeBox = false;
			Name = "CreatePaymentSampleForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProductNameForm";
			FormClosing += ProductNameForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbCategory;
		private TextBox textProductName;
		private ComboBox cbFindingTag;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnAccept;
		private Button btnCancel;
	}
}