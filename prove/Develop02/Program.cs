using System;
using System.Collections.Generic;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        int userChoice = -1;

        while (userChoice != 5)

        {
        Console.Write("Please select one of the following choices \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n ");
        Console.Write("What would you like to do? ");
        string userEntry = Console.ReadLine();
        userChoice = int.Parse(userEntry);
        Console.WriteLine(userChoice);
        }

    


        
    }

    
}