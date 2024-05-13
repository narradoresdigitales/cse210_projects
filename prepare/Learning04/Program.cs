using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assign1 = new Assignment("Marcus", "Programming");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment math1 = new MathAssignment("Marcus", "Programming", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Marcus Palmer", "C# Programming", "Elegant C#");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
                
        
    }
}