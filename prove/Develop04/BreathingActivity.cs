public class BreathingActivity : Activity {

public BreathingActivity () {
    _name = "Breathing Activity";
    _description = " ...";
}

public void Run() {
    DisplayStartingMessage();
    
    Console.WriteLine("The activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

    //Have the user breathe in for 5 seconds
    
    do {

    }
    while (DateTime.Now < stopTime);
    
    Console.WriteLine("Breathe In");
    ShowCountDown(_duration);
    
    //Have the user breathe out for 5 seconds
    Console.WriteLine("Breathe Out");
    ShowCountDown(_duration);



    //Repeat this for the duration (loop)

    DisplayEndingMessage();

}

}