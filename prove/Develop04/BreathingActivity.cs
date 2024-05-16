public class BreathingActivity : Activity {

public BreathingActivity () 
{
    Console.WriteLine();
    Console.WriteLine();
    _name = "Breathing Activity.";
    _description = "The activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
}

public void Run() 
{
    Console.WriteLine("_________________________________________________"); //spacing
    Console.WriteLine(); //spacing
    DisplayStartingMessage();
    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);
    ShowSpinner(5);
    Console.WriteLine(); //spacing
        
    do {
        Console.WriteLine("Breathe In"); //Have the user breathe in for 5 seconds
        ShowCountDown(_duration);
        Console.WriteLine();//spacing
        Console.WriteLine("Breathe Out"); //Have the user breathe out for 5 seconds
        ShowCountDown(_duration);
    }
    while (DateTime.Now < stopTime); //Repeat this for the duration (loop)
    Console.WriteLine();//spacing
    DisplayEndingMessage();

}

}