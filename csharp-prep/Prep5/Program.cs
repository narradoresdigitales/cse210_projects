using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
		string userName = PromptUsername();
		int userNum = PromptUserNumber();
		int squaredNum = SquareNumber(userNum);
		DisplayResult(userName, squaredNum);
		
		static void DisplayWelcome()
		{
    		Console.WriteLine("Welcome to the Program!");
		}
		
		static string PromptUsername()
			
		{
			Console.Write("Please enter your name:   ");
			string username = Console.ReadLine();
			
			return username;
		}

		static int PromptUserNumber()
		{
			Console.Write("Enter your favorite number: ");
			string response = Console.ReadLine();
			int userNum = int.Parse(response);

			return userNum;
		}

		static int SquareNumber(int number)
		{
			int square = number * number;
			return square;
		}

		static void DisplayResult(string name, int square)
		{
			Console.WriteLine($"{name}, the square of your number is {square}.");
		}

    }
}