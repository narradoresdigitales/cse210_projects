public class Activity {

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
        
        //Prompt for the duration?
        Console.Write("How long, in seconds, would you like your session? \n");  
        string userTime = Console.ReadLine(); 
        _duration = int. Parse(userTime);

        //ShowSpinner(5);

    }
    public void DisplayEndingMessage() {
        Console.WriteLine($"The {_name} activity is complete Great job!!");
        ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds) {
        //Watch video
        Console.WriteLine("Spinner!");
    }
    public void ShowCountDown(int seconds) {
        for (int i= _duration; i >0; i--)
        Console.WriteLine($"Time remaining: {i} seconds");
        Thread.Sleep(1000);
        Console.WriteLine("Countdown!");
    }

}