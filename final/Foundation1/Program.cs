using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Video Tracker");
        Console.WriteLine();

        // Begin to create instances of the video class

    Video video01 = new Video("Using Abstraction", "Marcus Palmer", 60);
    Video video02 = new Video("Using Encapsulation", "Marcus Palmer", 90);
    Video video03 = new Video("Using Inheritance", "Marcus Palmer", 120);
    Video video04 = new Video("Using Polymorphism", "Marcus Palmer", 150);



    // Add comments for video1

    video01.AddComment(new Comment("Alexander", "Great job!"));
    video01.AddComment(new Comment("Virginia", "Very Informative!"));
    video01.AddComment(new Comment("Mariela", "GWell explained!"));
    video01.AddComment(new Comment("Sandra", "Thanks for the insights!"));

    video02.AddComment(new Comment("Guillermo", "Great job!"));
    video02.AddComment(new Comment("Luna", "Very Informative!"));
    video02.AddComment(new Comment("Mario", "GWell explained!"));
    video02.AddComment(new Comment("Sylvan", "Thanks for the insights!"));
    video02.AddComment(new Comment("Mariela", "GWell explained!"));
    video02.AddComment(new Comment("Sandra", "Thanks for the insights!"));


    video03.AddComment(new Comment("Melissa", "Great job!"));
    video03.AddComment(new Comment("Malinda", "Very Informative!"));
    video03.AddComment(new Comment("Michael", "GWell explained!"));
    video03.AddComment(new Comment("Melanie", "Thanks for the insights!"));
    video03.AddComment(new Comment("Alexander", "Great job!"));
    video03.AddComment(new Comment("Virginia", "Very Informative!"));
    
    video04.AddComment(new Comment("Matthew", "Great job!"));
    video04.AddComment(new Comment("Miranda", "Very Informative!"));
    video04.AddComment(new Comment("Carol Ann", "GWell explained!"));
    video04.AddComment(new Comment("Ocho", "Thanks for the insights!"));
    video04.AddComment(new Comment("Malinda", "Very Informative!"));
    video04.AddComment(new Comment("Michael", "GWell explained!"));
    video04.AddComment(new Comment("Melanie", "Thanks for the insights!"));
    video04.AddComment(new Comment("Alexander", "Great job!"));
    video04.AddComment(new Comment("Virginia", "Very Informative!"));
    
    
    
    video01.DisplayInfo();
    Console.WriteLine();
    
    video02.DisplayInfo();
    Console.WriteLine();
    
    video03.DisplayInfo();
    Console.WriteLine();
    
    video04.DisplayInfo();
    Console.WriteLine();


    }
}