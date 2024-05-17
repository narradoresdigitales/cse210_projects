using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
public class ListingActivity : Activity
{

    //private int _count = 0;

    List<string> stringList = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity.";
        _description = "This activity will help you reflect on the good things in your life" +
        " by having you list as many things you can in a certain area."; //concatenation for readability
        _duration = 0; 
    }
    public void Run()
    {
        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine();
        DisplayStartingMessage();
        _duration = 10;
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        Console.WriteLine(); //spacing
        Console.WriteLine( _duration); // test code to ensure the variable is given a value.
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.Write("You may begin in:  ");
        
        for (int i= 5; i > 0; i--)
        {
            Console.Write(i);
            //Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        Console.WriteLine(">");
        GetListFromUser(stringList);
        Console.WriteLine($"You provided a total of {stringList.Count} entries. ");
        DisplayEndingMessage();
        
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine("---When have you felt the Holy Ghost this month? ---");
        
    }
    public int GetListFromUser(List<string> stringList) //this should not be void. I need to edit!!!
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < stopTime)
                
        {
            string userInput = Console.ReadLine();

            stringList.Add(userInput);
            _duration--;
        } 
        return stringList.Count;
    }

}