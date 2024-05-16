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
        Console.Write("How long, in seconds, would you like your session? > ");  
        string userTime = Console.ReadLine(); 
        _duration = int.Parse(userTime);

        //ShowSpinner(5);
    }
    public void DisplayEndingMessage() 
    
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        //ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds) 
    
    {
        //Watch video
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);



        while (DateTime.Now < endTime)
        {
            
        }


        List<string> animationStings = new List<string>();
        animationStings.Add("|");
        animationStings.Add("/");
        animationStings.Add("-");
        animationStings.Add("\\");
        animationStings.Add("|");
        animationStings.Add("-");
        animationStings.Add("\\");

        Console.Write("Get ready  ");
        foreach(string s in animationStings)
        {
            
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        
    }
    public void ShowCountDown(int seconds) 

    {
        for (int i= _duration; i >0; i--)
        Console.WriteLine($"Time remaining: {i} seconds");
        Thread.Sleep(1000);
        Console.WriteLine(); //spacing
    }

}