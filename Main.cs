namespace Calculator_ICE_Task_4_
{
	public partial class Form1 : Form
	{
		Calculator calc = new Calculator();
		public Form1()
		{
			InitializeComponent();

			calc.calculations += (operation) =>
			{
				MessageBox.Show($"Operation performed: {operation}", "Operation Performed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void bttnCalculate_Click(object sender, EventArgs e)
		{

		}

		public void CalculateAndDisplay(Func<int, int, double> operation)
		{
			if (int.TryParse(txtNum1.Text, out int num1) && int.TryParse(txtNum2.Text, out int num2))
			{
				double result = operation(num1, num2);
				txtResult.Text = result.ToString();
			}
			else
			{
				MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void bttnAdd_Click(object sender, EventArgs e)
		{
			CalculateAndDisplay(calc.Add);
		}

		private void bttnSub_Click(object sender, EventArgs e)
		{
			CalculateAndDisplay(calc.Subtract);
		}

		private void bttnMultiply_Click(object sender, EventArgs e)
		{
			CalculateAndDisplay(calc.Multiply);
		}

		private void bttnDivide_Click(object sender, EventArgs e)
		{
			CalculateAndDisplay(calc.Divide);
		}

		private void bttnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
