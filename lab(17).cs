using System;

// Interface Pass
interface Pass
{
	bool PassMethod(int mark);
}

// Interface Division
interface Division
{
	string DivisionMethod(int average);
}

// Class implementing both interfaces
class Result : Pass, Division
{
	// Implement Pass method
	public bool PassMethod(int mark)
	{
		if (mark >= 50)
			return true;
		else
			return false;
	}

	// Implement Division method
	public string DivisionMethod(int average)
	{
		if (average >= 75)
			return "Distinction";
		else if (average >= 60)
			return "First Division";
		else if (average >= 50)
			return "Second Division";
		else
			return "Fail";
	}
}

// Main class
class Program
{
	static void Main(string[] args)
	{
		Result r = new Result();

		int mark = 65;
		int average = 68;

		Console.WriteLine("Pass Status: " + r.PassMethod(mark));
		Console.WriteLine("Division: " + r.DivisionMethod(average));
	}
}
