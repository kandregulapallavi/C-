using System;

class PrimeCheck
{
	static void Main()
	{
		int num, i;
		bool isPrime = true;

		Console.Write("Enter a number: ");
		num = Convert.ToInt32(Console.ReadLine());

		if (num <= 1)
		{
			isPrime = false;
		}
		else
		{
			for (i = 2; i <= num / 2; i++)
			{
				if (num % i == 0)
				{
					isPrime = false;
					break;
				}
			}
		}

		if (isPrime)
			Console.WriteLine("Number is Prime");
		else
			Console.WriteLine("Number is Not Prime");
	}
}
