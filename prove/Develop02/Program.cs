using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();


        int userChoice = -1;

        while (userChoice != 5)

        {
            Console.Write("Please select one of the following choices \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n ");
            Console.Write("What would you like to do? ");
            string _promptText = Console.ReadLine();
            userChoice = int.Parse(_promptText);


            if (userChoice == 1)
            {
                Console.Write("How are you today? ");
                string response = Console.ReadLine();
                anEntry._entryText = response;

                DateTime theCurrentTime = DateTime.Now;
                string entryDate = theCurrentTime.ToShortDateString();
                anEntry._date = entryDate;

                anEntry.Display(anEntry._date, anEntry._entryText);


            }

            else if (userChoice == 2)
            {
                anEntry.Display(anEntry._date, anEntry._entryText);
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("You have chosen to load the journal.");
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("You have chosen to save the journal.");
            }

        }





    }


}