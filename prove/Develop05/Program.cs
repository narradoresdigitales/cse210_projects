using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Marcus, welcome to Develop05 World!");


        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine(); //spacing
        Console.WriteLine(); //spacing
        var choice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(); //spacing
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit:");

            Console.WriteLine("_________________________________________________"); //spacing
            Console.WriteLine(); //spacing
            Console.WriteLine(); //spacing
            Console.Write(" Select a choice from the menu: > ");
            choice = Console.ReadLine();
            
        
            
            if (choice == "1")
            {
                
                                
            }
            else if (choice == "2")
            {
                
                
            }
            else if (choice == "3")
            {
                
                
            }
            else if (choice == "4")
            {
                
                
            }
            else if (choice == "5")
            {
                
                
            }
            else if (choice == "6")
            {
                Console.WriteLine("You selected to exit. Goodbye");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try again.");
            }

        }
        while (choice != "6");

        
    }

}
