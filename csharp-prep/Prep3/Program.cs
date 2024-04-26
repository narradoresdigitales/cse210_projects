using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 4;

        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int guess = int.Parse(userInput);

        Console.WriteLine($"Your guess is {guess}");

        
        if (guess == x)
        {
            Console.Write("You are correct. ");

        }

        else if (guess != x)
    {
        Console.Write("Good try, but guess again. ");
    }








    }
        

}