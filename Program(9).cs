using System;

class FibonacciProgram
{
	static void Main()
	{
		int n, a = 0, b = 1, c;

		Console.Write("Enter the limit: ");
		n = Convert.ToInt32(Console.ReadLine());

		Console.Write("Fibonacci Series: " + a + " " + b + " ");

		for (int i = 2; ; i++)
		{
			c = a + b;
			if (c > n)
				break;

			Console.Write(c + " ");
			a = b;
			b = c;
		}
	}
}
