public class BreathingActivity : Activity {

public BreathingActivity () {
    _name = "Breathing Activity";
    _description = " ...";
}

public void Run() {
    DisplayStartingMessage();

    //Have the user breathe in for 5 seconds
    Console.WriteLine("Breathe In");
    ShowCountDown(5);
    
    //Have the user breathe out for 5 seconds
    Console.WriteLine("Breathe Out");
    ShowCountDown(5);



    //Repeat this for the duration (loop)

    DisplayEndingMessage();

}

}