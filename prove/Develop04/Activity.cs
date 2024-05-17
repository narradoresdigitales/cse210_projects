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
        Console.Write("How long, in seconds, would you like your session? > "); //Prompt for the duration?
        string userTime = Console.ReadLine(); 
        _duration = int.Parse(userTime);
        Console.WriteLine(); 
        Console.WriteLine("Get ready... "); 
        ShowSpinner(5);
        Console.WriteLine("-----------"); 
    }
    public void DisplayEndingMessage() 
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void ShowSpinner(int seconds) 
    {
        List<string> animationStings = new List<string>();
        animationStings.Add("|");
        animationStings.Add("/");
        animationStings.Add("-");
        animationStings.Add("\\");
        animationStings.Add("|");
        animationStings.Add("-");
        animationStings.Add("\\");
        
        foreach(string s in animationStings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    public void ShowCountDown(int seconds) 
    {
        for (int i= 4; i > 0; i--)
        {
            Console.Write(i);
            //Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        
    }
    
}