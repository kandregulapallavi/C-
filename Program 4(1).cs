using System;

class Program
{
	static void Main()
	{
		double num1, num2, result = 0;
		char op;

		Console.Write("Enter first number: ");
		num1 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter second number: ");
		num2 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter operator (+, -, *, /): ");
		op = Convert.ToChar(Console.ReadLine());

		switch (op)
		{
			case '+':
				result = num1 + num2;
				Console.WriteLine("Result = " + result);
				break;

			case '-':
				result = num1 - num2;
				Console.WriteLine("Result = " + result);
				break;

			case '*':
				result = num1 * num2;
				Console.WriteLine("Result = " + result);
				break;

			case '/':
				if (num2 != 0)
				{
					result = num1 / num2;
					Console.WriteLine("Result = " + result);
				}
				else
				{
					Console.WriteLine("Error: Division by zero");
				}
				break;

			default:
				Console.WriteLine("Invalid operator");
				break;
		}
	}
}
