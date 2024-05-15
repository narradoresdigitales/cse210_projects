using System.Collections.Generic;
public class ListingActivity : Activity{

    int _count;

    List<string> stringList = new List<string>();
    

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = @"This activity will help you reflect on the good things in your life by having you list as many 
            things you can in a certain area";
        _duration = 0; 
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine("You may begin in: \n >");
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        stringList.Add("---When have you felt the Holy Ghost this month? ---");
        Console.WriteLine(stringList[0]);
    }

    public void GetListFromUser() //this should not be void. I need to edit!!!
    {
        //List<string>
    }

}