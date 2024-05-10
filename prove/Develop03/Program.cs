using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

class Program
{
        static void Main(string[] args)
        {
        string toQuite = " ";

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = @"Trust in the Lord with all thine heart; and lean not unto thine own understanding.

        In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, scriptureText);

    do
    {
        Console.WriteLine();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("\nPress enter to continue or type 'quite' to finish");

        toQuite = Console.ReadLine();
        Console.Clear();

        if (toQuite != "quite")
        {
            scripture.HideRandomWords(1);
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("try to memorize!");
            break;
        }
    } while (toQuite != "quite");


    } 
}  