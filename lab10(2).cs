using System;

class LoanEligibility
{
	static void Main()
	{
		int age, creditScore;
		double income;

		Console.Write("Enter your age: ");
		age = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter your monthly income: ");
		income = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter your credit score: ");
		creditScore = Convert.ToInt32(Console.ReadLine());

		
		if (age >= 21 && age <= 60)
		{
			if (income >= 25000)
			{
				if (creditScore >= 700)
				{
					Console.WriteLine("Loan Approved ✅");
				}
				else
				{
					Console.WriteLine("Loan Rejected ❌ (Low Credit Score)");
				}
			}
			else
			{
				Console.WriteLine("Loan Rejected ❌ (Insufficient Income)");
			}
		}
		else
		{
			Console.WriteLine("Loan Rejected ❌ (Age not eligible)");
		}
	}
}
