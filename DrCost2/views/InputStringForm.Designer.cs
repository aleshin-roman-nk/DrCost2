namespace DrCost2.views
{
	partial class InputStringForm
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
			textBox1 = new TextBox();
			lblPrompt = new Label();
			btnOk = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(13, 45);
			textBox1.Margin = new Padding(4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(558, 34);
			textBox1.TabIndex = 0;
			// 
			// lblPrompt
			// 
			lblPrompt.AutoSize = true;
			lblPrompt.Location = new Point(16, 13);
			lblPrompt.Margin = new Padding(4, 0, 4, 0);
			lblPrompt.Name = "lblPrompt";
			lblPrompt.Size = new Size(79, 28);
			lblPrompt.TabIndex = 1;
			lblPrompt.Text = "prompt";
			// 
			// btnOk
			// 
			btnOk.Location = new Point(464, 86);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(107, 56);
			btnOk.TabIndex = 2;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(340, 86);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(107, 56);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// InputStringForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 154);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(lblPrompt);
			Controls.Add(textBox1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "InputStringForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "InputStringForm";
			FormClosing += InputStringForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label lblPrompt;
		private Button btnOk;
		private Button btnCancel;
	}
}