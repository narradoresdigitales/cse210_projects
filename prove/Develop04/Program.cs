using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity:");
            Console.WriteLine(" 2. Start reflecting activity:");
            Console.WriteLine(" 3. Start listing activity:");
            Console.WriteLine(" 4. Quit:");
            Console.WriteLine(" Select a choice from the menu.");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivity.ShowSpinner(5);
                breathingActivity.ShowCountDown(5); 
                breathingActivity.DisplayEndingMessage();
                breathingActivity.ShowSpinner(5);
                Console.Clear();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                //reflectingActivity.ShowSpinner(5);
                reflectingActivity.DisplayEndingMessage();
                
                
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingActivity.GetRandomPrompt();
                listingActivity.GetListFromUser();
                Console.Clear();
                
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