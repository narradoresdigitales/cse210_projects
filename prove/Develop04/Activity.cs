using System.Xml.Serialization;

public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        //Initialize _name, _description, _duration
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        //Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        
        Console.WriteLine();//spacing
        
        Console.WriteLine($"{_description}");

        Console.WriteLine();//spacing
        //Prompt for the duration?
        Console.WriteLine("How long, in seconds, would you like your session? ");  
        string userTime = Console.ReadLine(); 
        _duration = int. Parse(userTime);

        //ShowSpinner(5);
    }
    public void DisplayEndingMessage() 
    
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds) 
    
    {
        //Watch video
        Console.WriteLine("Spinner!");
    }
    public void ShowCountDown(int seconds) 

    {
        for (int i= _duration; i >0; i--)
        Console.WriteLine($"Time remaining: {i} seconds");
        Thread.Sleep(1000);
        Console.WriteLine("Countdown!");
    }

}