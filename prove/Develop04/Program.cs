using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity:");
            Console.WriteLine(" 2. Start reflecting activity:");
            Console.WriteLine(" 3. Start listening activity:");
            Console.WriteLine(" 4. Quit:");
            Console.WriteLine(" Select a choice from the menu.");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.ShowSpinner(5);
                breathingActivity.ShowCountDown(5); 
                breathingActivity.DisplayEndingMessage();

            }
            else if (choice == "2")
            {
                Console.WriteLine(" 2. You selected to start the reflecting activity:");
            }
            else if (choice == "3")
            {
                Console.WriteLine(" 3. You selected to start the listening activity:");
            }
            else if (choice == "4")
            {
                Console.WriteLine("You selected to exit. Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try again.");
            }

        }
        while (choice != "4");



    }
}