using System.Diagnostics.Contracts;

public class Activity

{
    public string Date {get; private set;}
    public double Distance {get; protected set;}
    public double Speed {get; protected set;}
    public double Pace {get; protected set;}


    public Activity(string date, double distance)
    {
        Date = date;
        Distance = distance;
    }

    //virtual method to get distance, speed, and pace

    /*
        Distance (km) = swimming laps * 50 / 1000
        Distance (miles) = swimming laps * 50 / 1000 * 0.62

    */


    // Distance (miles) = swimming laps * 50 / 1000 * 0.62
    public virtual double GetDistance()
    {
        return Distance;
    }
        // Speed (mph or kph) = (distance / minutes) * 60
    public virtual double GetSpeed(double distance, double minutes)
    {
        return (distance / minutes) * 60;
    }
        //Pace (min per mile or min per km)= minutes / distance
    public virtual double GetPace(double minutes, double distance)
    {
        return (minutes / distance);
    }

}