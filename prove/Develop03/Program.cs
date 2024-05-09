using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3, 5,6);
        Console.Write(r1.GetDisplayText());
        
        Scripture scripture1 = new Scripture(r1, "text");
        Console.WriteLine(  scripture1.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: \n ");
    } 
}  