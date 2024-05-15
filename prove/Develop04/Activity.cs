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
        Console.WriteLine("How long, in second, would you like your session?");  
        //Prompt for the duration?
        ShowSpinner(5);

    }
    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds) {
        //Watch video
        Console.WriteLine("Spinner!");
    }
    public void ShowCountDown(int seconds) {
        Console.WriteLine("Countdown!");
    }

}