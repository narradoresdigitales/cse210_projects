using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage <90 && gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage <80 && gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage <70 && gradePercentage >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is: {letter}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed! ");
        }
        else 
        {
            Console.WriteLine("Don't give up! You can do this!");
        }

    }
}