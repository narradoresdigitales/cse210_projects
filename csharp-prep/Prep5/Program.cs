using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
		Username();
		
		static void DisplayMessage()
		{
    		Console.WriteLine("Welcome to the Program!");
		}
		
		static string Username()
			
		{
			Console.Write("Please enter your name:   ");
			string username = Console.ReadLine();
			
			return username;
		}
    }
}