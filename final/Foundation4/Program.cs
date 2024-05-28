using System;



/// <summary>
/// 
///  Write an app for their customers to track their exercise. They have facilities for the following:
///
/// Running,  Stationary Bicycles, Swimming in the lap pool
/// 
/// For each activity, they want to track the the date and the length of the activity in minutes. 
/// 
/// For each activity, they would like to also track the following: Running: distance,  Cycling: speed,  Swimming: number of laps
/// 
/// Get following information (by calculation if it is not stored directly): 
/// --The distance
/// --The speed (miles per hour or kilometers per hour)
/// --The pace (minutes per mile or minutes per kilometer)
/// 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Marcus, Foundation4 World!");
        Console.WriteLine();

        Console.WriteLine("Activity Summaries:");
        Console.WriteLine();

        Running run = new Running ("28 May 2024", 30, 3.0);
        Cycling cycle = new Cycling("29 May 2024", 45, 15.0);
        Swimming swim = new Swimming("30 May 2024", 40);

        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine(swim.GetSummary());



    }










}