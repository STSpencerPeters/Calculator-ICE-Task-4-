namespace Calculator_ICE_Task_4_
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			lblEnterNumbers = new Label();
			txtNum1 = new TextBox();
			txtNum2 = new TextBox();
			bttnAdd = new Button();
			bttnSub = new Button();
			bttnMultiply = new Button();
			bttnDivide = new Button();
			label2 = new Label();
			txtResult = new TextBox();
			bttnClose = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F);
			label1.Location = new Point(262, 39);
			label1.Name = "label1";
			label1.Size = new Size(200, 54);
			label1.TabIndex = 0;
			label1.Text = "Calculator";
			// 
			// lblEnterNumbers
			// 
			lblEnterNumbers.AutoSize = true;
			lblEnterNumbers.Font = new Font("Segoe UI", 15F);
			lblEnterNumbers.Location = new Point(297, 135);
			lblEnterNumbers.Name = "lblEnterNumbers";
			lblEnterNumbers.Size = new Size(146, 28);
			lblEnterNumbers.TabIndex = 1;
			lblEnterNumbers.Text = "Enter Numbers:";
			// 
			// txtNum1
			// 
			txtNum1.Font = new Font("Segoe UI", 15F);
			txtNum1.Location = new Point(194, 234);
			txtNum1.Name = "txtNum1";
			txtNum1.Size = new Size(100, 34);
			txtNum1.TabIndex = 2;
			// 
			// txtNum2
			// 
			txtNum2.Font = new Font("Segoe UI", 15F);
			txtNum2.Location = new Point(412, 234);
			txtNum2.Name = "txtNum2";
			txtNum2.Size = new Size(100, 34);
			txtNum2.TabIndex = 3;
			// 
			// bttnAdd
			// 
			bttnAdd.Font = new Font("Segoe UI", 15F);
			bttnAdd.Location = new Point(174, 331);
			bttnAdd.Name = "bttnAdd";
			bttnAdd.Size = new Size(143, 55);
			bttnAdd.TabIndex = 4;
			bttnAdd.Text = "Addition";
			bttnAdd.UseVisualStyleBackColor = true;
			bttnAdd.Click += bttnAdd_Click;
			// 
			// bttnSub
			// 
			bttnSub.Font = new Font("Segoe UI", 15F);
			bttnSub.Location = new Point(412, 331);
			bttnSub.Name = "bttnSub";
			bttnSub.Size = new Size(143, 55);
			bttnSub.TabIndex = 5;
			bttnSub.Text = "Subtraction";
			bttnSub.UseVisualStyleBackColor = true;
			bttnSub.Click += bttnSub_Click;
			// 
			// bttnMultiply
			// 
			bttnMultiply.Font = new Font("Segoe UI", 15F);
			bttnMultiply.Location = new Point(174, 431);
			bttnMultiply.Name = "bttnMultiply";
			bttnMultiply.Size = new Size(143, 55);
			bttnMultiply.TabIndex = 6;
			bttnMultiply.Text = "Multiplication";
			bttnMultiply.UseVisualStyleBackColor = true;
			bttnMultiply.Click += bttnMultiply_Click;
			// 
			// bttnDivide
			// 
			bttnDivide.Font = new Font("Segoe UI", 15F);
			bttnDivide.Location = new Point(412, 431);
			bttnDivide.Name = "bttnDivide";
			bttnDivide.Size = new Size(143, 55);
			bttnDivide.TabIndex = 7;
			bttnDivide.Text = "Division";
			bttnDivide.UseVisualStyleBackColor = true;
			bttnDivide.Click += bttnDivide_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F);
			label2.Location = new Point(226, 555);
			label2.Name = "label2";
			label2.Size = new Size(68, 28);
			label2.TabIndex = 9;
			label2.Text = "Result:";
			label2.Click += label2_Click;
			// 
			// txtResult
			// 
			txtResult.Font = new Font("Segoe UI", 15F);
			txtResult.Location = new Point(343, 555);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(100, 34);
			txtResult.TabIndex = 10;
			// 
			// bttnClose
			// 
			bttnClose.Font = new Font("Segoe UI", 15F);
			bttnClose.Location = new Point(530, 542);
			bttnClose.Name = "bttnClose";
			bttnClose.Size = new Size(143, 55);
			bttnClose.TabIndex = 11;
			bttnClose.Text = "Close";
			bttnClose.UseVisualStyleBackColor = true;
			bttnClose.Click += bttnClose_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(781, 666);
			Controls.Add(bttnClose);
			Controls.Add(txtResult);
			Controls.Add(label2);
			Controls.Add(bttnDivide);
			Controls.Add(bttnMultiply);
			Controls.Add(bttnSub);
			Controls.Add(bttnAdd);
			Controls.Add(txtNum2);
			Controls.Add(txtNum1);
			Controls.Add(lblEnterNumbers);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblEnterNumbers;
		private TextBox txtNum1;
		private TextBox txtNum2;
		private Button bttnAdd;
		private Button bttnSub;
		private Button bttnMultiply;
		private Button bttnDivide;
		private Label label2;
		private TextBox txtResult;
		private Button bttnClose;
	}
}
