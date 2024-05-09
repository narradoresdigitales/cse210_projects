using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        
        Console.WriteLine(r1.GetDisplayText());
        
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: \n ");
    } 
}  