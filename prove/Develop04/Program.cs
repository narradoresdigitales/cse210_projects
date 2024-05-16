using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine(); //spacing
        Console.WriteLine(); //spacing
        var choice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(); //spacing
            Console.WriteLine(" 1. Start breathing activity:");
            Console.WriteLine(" 2. Start reflecting activity:");
            Console.WriteLine(" 3. Start listing activity:");
            Console.WriteLine(" 4. Quit:");

            Console.WriteLine("_________________________________________________"); //spacing
            Console.WriteLine(); //spacing
            Console.WriteLine(); //spacing
            Console.Write(" Select a choice from the menu: > ");
            choice = Console.ReadLine();
            
        
            
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                                
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                
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