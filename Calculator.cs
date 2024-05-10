using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ICE_Task_4_
{
	public delegate void CalculatorActions(string operation);
	public class Calculator
	{
		public event CalculatorActions calculations;

		public double Add(int x, int y)
		{
			calculations?.Invoke("Addition");
			return x + y;
		}

		public double Subtract(int x, int y)
		{
			calculations?.Invoke("Subtraction");
			return x - y;
		}

		public double Multiply(int x, int y)
		{
			calculations?.Invoke("Multiplication");
			return x * y;
		}

		public double Divide(int x, int y)
		{
			calculations?.Invoke("Division");
			if(y == 0)
			{
				/*
				 * Code Attribution:
				 * Reference: Ashkan Mobayen Khiabani. (2021). Message Box Icon -> Variable?
				*/
				MessageBox.Show("Error: Division by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return double.NaN;
			}
			return (double)x / y;
		}
	}
}
