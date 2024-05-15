public class BreathingActivity : Activity {

public BreathingActivity () {
    _name = "Breathing Activity";
    _description = " ...";
}

public void Run() {
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

    //Have the user breathe in for 5 seconds
    do {

    }
    while (DateTime.Now < stopTime);
    
    Console.WriteLine("Breathe In");
    ShowCountDown(5);
    
    //Have the user breathe out for 5 seconds
    Console.WriteLine("Breathe Out");
    ShowCountDown(5);



    //Repeat this for the duration (loop)

    DisplayEndingMessage();

}

}