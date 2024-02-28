namespace DrCost2.views
{
	partial class ProductNameSelectForm
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
			btnAccept = new Button();
			textProductName = new TextBox();
			listBoxFindingTags = new ListBox();
			listViewProductNames = new ListView();
			btnAddProductName = new Button();
			textCategory = new TextBox();
			SuspendLayout();
			// 
			// btnAccept
			// 
			btnAccept.Enabled = false;
			btnAccept.Location = new Point(785, 14);
			btnAccept.Margin = new Padding(4);
			btnAccept.Name = "btnAccept";
			btnAccept.Size = new Size(60, 55);
			btnAccept.TabIndex = 0;
			btnAccept.Text = "ok";
			btnAccept.UseVisualStyleBackColor = true;
			btnAccept.Click += btnAccept_Click;
			// 
			// textProductName
			// 
			textProductName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textProductName.Location = new Point(331, 76);
			textProductName.Name = "textProductName";
			textProductName.ReadOnly = true;
			textProductName.Size = new Size(569, 34);
			textProductName.TabIndex = 1;
			// 
			// listBoxFindingTags
			// 
			listBoxFindingTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			listBoxFindingTags.FormattingEnabled = true;
			listBoxFindingTags.ItemHeight = 28;
			listBoxFindingTags.Location = new Point(12, 76);
			listBoxFindingTags.Name = "listBoxFindingTags";
			listBoxFindingTags.Size = new Size(313, 592);
			listBoxFindingTags.TabIndex = 2;
			listBoxFindingTags.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
			// 
			// listViewProductNames
			// 
			listViewProductNames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			listViewProductNames.Location = new Point(331, 116);
			listViewProductNames.Name = "listViewProductNames";
			listViewProductNames.Size = new Size(569, 552);
			listViewProductNames.TabIndex = 3;
			listViewProductNames.UseCompatibleStateImageBehavior = false;
			listViewProductNames.View = View.List;
			listViewProductNames.SelectedIndexChanged += listViewProductNames_SelectedIndexChanged;
			listViewProductNames.MouseDoubleClick += listViewProductNames_MouseDoubleClick;
			// 
			// btnAddProductName
			// 
			btnAddProductName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddProductName.Location = new Point(852, 12);
			btnAddProductName.Name = "btnAddProductName";
			btnAddProductName.Size = new Size(48, 56);
			btnAddProductName.TabIndex = 4;
			btnAddProductName.Text = "+";
			btnAddProductName.UseVisualStyleBackColor = true;
			btnAddProductName.Click += btnAddProductName_Click;
			// 
			// textCategory
			// 
			textCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			textCategory.Location = new Point(12, 14);
			textCategory.Name = "textCategory";
			textCategory.ReadOnly = true;
			textCategory.Size = new Size(706, 47);
			textCategory.TabIndex = 5;
			// 
			// ProductNameSelectForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(912, 691);
			Controls.Add(textCategory);
			Controls.Add(btnAddProductName);
			Controls.Add(listViewProductNames);
			Controls.Add(listBoxFindingTags);
			Controls.Add(textProductName);
			Controls.Add(btnAccept);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "ProductNameSelectForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProductTypeSelectForm";
			FormClosing += ProductTypeSelectForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAccept;
		private TextBox textProductName;
		private ListBox listBoxFindingTags;
		private ListView listViewProductNames;
		private Button btnAddProductName;
		private TextBox textCategory;
	}
}