using System;

/// <summary>
///  Write a program to track each of these events and produce the marketing material to distribute on social media. 
/// 
/// Write a program that creates at least one event of each type and sets all of their values
/// 
/// Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
/// 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Marcus, Foundation3 World!");
        Console.WriteLine();

        Address address1 = new Address("123 Main St", "Happy Town", "Texas", "USA");
        Address address2 = new Address("123 Calle Main", "Good Winds", "Buenos Aires", "Argentina");

        Lecture lecture = new Lecture("Selling Your Inheritance in C#", "How to Avoid Common Errors", "2024-05-28", "10:00 AM", address1, "Dr. Marcus Palmer", 175);
        Reception reception = new Reception("Celebrating Inheritance in C#", "A formal evening event", "2024-05-28", "6:00 PM", address1, "rsvp@narradoresdigitales@gmail.com" );
        OutdoorGathering gathering = new OutdoorGathering("Community Picnic", "An outdoor event for the C# community","2024-06-23", "10:00 AM - 10:00 PM", address2, "Plenty of sunshine and mild temperatures" );

        
        Console.WriteLine("Lecture, Standard Details:");
        Console.WriteLine(lecture.PublishStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Reception, Standard Details:");
        Console.WriteLine(reception.PublishFullDetails());
        Console.WriteLine();

        Console.WriteLine("Gathering, Standard Details:");
        Console.WriteLine(gathering.PublishFullDetails());
        Console.WriteLine();
        
        
        Console.WriteLine("Lecture, Full Details:");
        Console.WriteLine(lecture.PublishFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception, Full Details: ");
        Console.WriteLine(reception.PublishFullDetails());
        Console.WriteLine();

        Console.WriteLine("Gathering, Full Details: ");
        Console.WriteLine(gathering.PublishFullDetails());
        Console.WriteLine();

///

        Console.WriteLine("Lecture, Short Description:");
        Console.WriteLine(lecture.PublishShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Short Description: ");
        Console.WriteLine(reception.PublishShortDescription());
        Console.WriteLine();

        Console.WriteLine("Gathering Short Description: ");
        Console.WriteLine(gathering.PublishShortDescription());
        Console.WriteLine();












    }
}