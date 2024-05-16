using System.Collections.Generic;
public class ListingActivity : Activity{

    int _count;

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
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Thread.Sleep(1500);
        Console.Write("You may begin in:  ");
        
        for (int i= 5; i > 0; i--)
        {
            Console.Write(i);
            //Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        DisplayEndingMessage();
        Console.WriteLine();
        Console.WriteLine();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        stringList.Add("---When have you felt the Holy Ghost this month? ---");
        Console.WriteLine(stringList[0]);
    }

    public void GetListFromUser() //this should not be void. I need to edit!!!
    {
        //List<string>
    }

}