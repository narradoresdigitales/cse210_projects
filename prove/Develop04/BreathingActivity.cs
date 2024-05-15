public class BreathingActivity : Activity {

public BreathingActivity () {
    _name = "Breathing Activity";
    _description = @"The activity will help you relax by walking through breathing in and out slowly. 
    Clear your mind and focus on your breathing.";
}

public void Run() {
    DisplayStartingMessage();
    
    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);
    Console.WriteLine("Get ready ... ");
    Console.WriteLine(); //spacing
    //Have the user breathe in for 5 seconds
    
    do {
        Console.WriteLine("Breathe In");
        ShowCountDown(_duration);
        Console.WriteLine("Breathe Out");
        ShowCountDown(_duration);
    }
    while (DateTime.Now < stopTime);
    
    
    
    //Have the user breathe out for 5 seconds
    



    //Repeat this for the duration (loop)

    DisplayEndingMessage();

}

}