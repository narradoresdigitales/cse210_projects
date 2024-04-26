using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
		int userNum = -1;

		while (userNum != 0)

		{
			Console.Write("Make a list of positive numbers (enter 0 to quit: ");
			string userEntry = (Console.ReadLine());
			userNum = int.Parse(userEntry);
		
		}
		if (userNum != 0)
		{
			numbers.Add(userNum);
		}

		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number;
		}

		Console.WriteLine($"The sum of the list is: {sum}.");

		float average = ((float)sum) / numbers.Count;
		Console.WriteLine($"The average for the list is {average}.");

		int max = numbers[0];

		foreach (int number in numbers)
		{
			if (number > max)
			{
				max = number;
			}
		}

		Console.WriteLine($"The max number for the list is {max}.");
    
    }
}