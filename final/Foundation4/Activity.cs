public class Activity

{

    public string Date {get; private set;}
    public int Distance {get; private set;}

    public int Speed {get; private set;}

    public int Pace {get; private set;}


    public Activity(string date, int distance, int speed, int pace)
    {
        Date = date;
        Distance = distance;
        Speed = speed;
        Pace = pace;
    }

    //virtual method to get distance, speed, and pace

    /*
        Distance (km) = swimming laps * 50 / 1000
        Distance (miles) = swimming laps * 50 / 1000 * 0.62
        Speed (mph or kph) = (distance / minutes) * 60
        Pace (min per mile or min per km)= minutes / distance
        Speed = 60 / pace
        Pace = 60 / speed


    */



}