namespace DrCost2.views
{
	partial class PartitionManagerForm
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
			listViewFindingTags = new ListView();
			listViewPaymentCategories = new ListView();
			btnAddFindingTag = new Button();
			btnAddCategory = new Button();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// listViewFindingTags
			// 
			listViewFindingTags.Location = new Point(16, 102);
			listViewFindingTags.Margin = new Padding(4, 4, 4, 4);
			listViewFindingTags.Name = "listViewFindingTags";
			listViewFindingTags.Size = new Size(412, 510);
			listViewFindingTags.TabIndex = 0;
			listViewFindingTags.UseCompatibleStateImageBehavior = false;
			listViewFindingTags.View = View.List;
			// 
			// listViewPaymentCategories
			// 
			listViewPaymentCategories.Location = new Point(436, 102);
			listViewPaymentCategories.Margin = new Padding(4, 4, 4, 4);
			listViewPaymentCategories.Name = "listViewPaymentCategories";
			listViewPaymentCategories.Size = new Size(486, 510);
			listViewPaymentCategories.TabIndex = 1;
			listViewPaymentCategories.UseCompatibleStateImageBehavior = false;
			listViewPaymentCategories.View = View.List;
			// 
			// btnAddFindingTag
			// 
			btnAddFindingTag.Location = new Point(16, 17);
			btnAddFindingTag.Margin = new Padding(4, 4, 4, 4);
			btnAddFindingTag.Name = "btnAddFindingTag";
			btnAddFindingTag.Size = new Size(170, 41);
			btnAddFindingTag.TabIndex = 2;
			btnAddFindingTag.Text = "add finding tag";
			btnAddFindingTag.UseVisualStyleBackColor = true;
			btnAddFindingTag.Click += btnAddFindingTag_Click;
			// 
			// btnAddCategory
			// 
			btnAddCategory.Location = new Point(195, 17);
			btnAddCategory.Margin = new Padding(4, 4, 4, 4);
			btnAddCategory.Name = "btnAddCategory";
			btnAddCategory.Size = new Size(191, 41);
			btnAddCategory.TabIndex = 3;
			btnAddCategory.Text = "add category";
			btnAddCategory.UseVisualStyleBackColor = true;
			btnAddCategory.Click += btnAddCategory_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 70);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(120, 28);
			label1.TabIndex = 4;
			label1.Text = "Тега поиска";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(436, 70);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(108, 28);
			label2.TabIndex = 5;
			label2.Text = "Категории";
			// 
			// PartitionManagerForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(935, 630);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnAddCategory);
			Controls.Add(btnAddFindingTag);
			Controls.Add(listViewPaymentCategories);
			Controls.Add(listViewFindingTags);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			Name = "PartitionManagerForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PartitionManagerForm";
			FormClosing += PartitionManagerForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listViewFindingTags;
		private ListView listViewPaymentCategories;
		private Button btnAddFindingTag;
		private Button btnAddCategory;
		private Label label1;
		private Label label2;
	}
}