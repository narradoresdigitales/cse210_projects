using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt;
        int choice = 1;
        string anAnswer;
        DateTime theCurrentTime = DateTime.Now;
        string dateToText;
        string anPrompt;
        int number;
        bool validatorOfTheNumberFromUser;

        Journal theJournal = new Journal();
        Entry anEntry;

        while (choice != 5)

        {
            Console.WriteLine("Please select one of the following choices \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n ");
            Console.WriteLine("What would you like to do? \n > ");
            string stringChoice = Console.ReadLine();
            validatorOfTheNumberFromUser = int.TryParse(stringChoice, out number);

            if (stringChoice == "" || (!validatorOfTheNumberFromUser))
            {
                choice = 7;
            }
            else
            {
                choice = int.Parse(stringChoice);
            }
        
            switch (choice)
            {
                case 1:
                    anEntry = new Entry();
                    prompt = new PromptGenerator();

                    anPrompt = prompt.GetRandomPrompt();
                    anEntry._promptText = anPrompt;

                    dateToText = theCurrentTime.ToShortDateString();
                    anEntry._date = dateToText;

                    Console.WriteLine($"\n {anPrompt}\n");

                    anAnswer = Console.ReadLine();
                    anEntry._entryText = anAnswer;

                    theJournal.AddEntry(anEntry);
                    break;

                case 2:
                    theJournal.DisplayAll();
                    break;
                
                case 3:

                    Console.Write("\n Please type the name of your file (with the extension (.csv or .txt)): ");
                    string nameFileLoaded = Console.ReadLine();

                    theJournal.LoadFromFile(nameFileLoaded);
                    break;
                
                case 4:

                    Console.WriteLine("You are going to save your prompts \n");
                    
                    Console.WriteLine("Enter the name of your journal: ");
                    string nameFile = Console.ReadLine();
                    int typeFile;

                    Console.WriteLine("\n What do you prefer? \n1)txt \n2)csv? ");
                    typeFile = int.Parse(Console.ReadLine()); 

                    switch (typeFile) 
                    {
                        case 1:
                        theJournal.SaveToFile($"{nameFile}.csv");
                        Console.WriteLine("\n The file was saved successfully.");
                        break;
                        
                        case 2:
                            theJournal.SaveToFile($"{nameFile}.csv");
                            Console.WriteLine("\n The file was saved successfully");
                        break;
                        case >2:
                            Console.WriteLine("\n INVALID \n");
                            break;
                        case <1:
                            Console.WriteLine("\n INVALID \n");
                            break;

                    }
                    break;
                case >=5:
                    break;
            }

        }
        Console.WriteLine("\n Great job at writing in your journal today. Keep up the effort!");

    }

}