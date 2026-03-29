using System;

class EvenOdd
{
	static void Main()
	{
		int num;

		Console.Write("Enter a number: ");
		num = Convert.ToInt32(Console.ReadLine());

		if (num % 2 == 0)
		{
			Console.WriteLine("The number is Even");
		}
		else
		{
			Console.WriteLine("The number is Odd");
		}
	}
}
