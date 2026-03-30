using System;

class ElectricityBill
{
	static void Main()
	{
		double units, rate = 5.0;
		double amount, discount = 0;
		int choice;

		Console.Write("Enter units consumed: ");
		units = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Select Customer Category:");
		Console.WriteLine("1. Senior Citizen");
		Console.WriteLine("2. Regular");
		Console.WriteLine("3. Industrial");
		Console.Write("Enter your choice (1-3): ");
		choice = Convert.ToInt32(Console.ReadLine());

		// Calculate total amount
		amount = units * rate;

		// Apply discount
		switch (choice)
		{
			case 1:
				discount = amount * 0.20; // 20%
				break;
			case 2:
				discount = amount * 0.10; // 10%
				break;
			case 3:
				discount = amount * 0.05; // 5%
				break;
			default:
				Console.WriteLine("Invalid choice!");
				return;
		}

		double finalBill = amount - discount;

		// Display result
		Console.WriteLine("\nTotal Amount: " + amount);
		Console.WriteLine("Discount: " + discount);
		Console.WriteLine("Final Bill: " + finalBill);
	}
}
