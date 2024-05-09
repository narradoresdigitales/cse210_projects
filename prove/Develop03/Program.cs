using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
    
        
        Reference r1 = new Reference("Proverbs", 3, 5,6);
        Word w = new Word("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.Write(r1.GetDisplayText());
        Console.WriteLine(w.GetDisplayText());
        
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish: \n  > ");
        var line = Console.ReadLine();

        //I referenced the 'stack overflow' discussion to write 'if' syntax to read a null line or when the user presses 'enter.'
        //https://stackoverflow.com/questions/32655870/how-to-read-enter-from-the-keyboard-to-exit-program

        if (string.IsNullOrEmpty(line)) 
            {
            Console.WriteLine("Let's begin to study the scriptures.");
            Console.WriteLine();
            
            }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The program has been terminated.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);
        }

        



    } 
}  