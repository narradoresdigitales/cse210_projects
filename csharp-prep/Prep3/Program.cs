using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNum = 4;
        int guess = -1;
    
    while (guess != magicNum)
    {

        Console.Write("Guess the Magic Number! ");
        guess = int.Parse(Console.ReadLine());

        if (magicNum > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNum < guess)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You got it! Great guess!");
        }
    }




    }
        

}