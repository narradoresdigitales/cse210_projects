using System;
using System.Security.Cryptography.X509Certificates;
public class Running: Activity

{
    private double minutes; 

    public Running(string date, double distance, double minutes): base(date, distance)
    {
        this.minutes = minutes;
        Speed = GetSpeed(distance, minutes);
        Pace = GetPace(minutes, distance);

    }

        public override double GetDistance()
        {
            return Distance;
        }

    public override double GetPace(double minutes, double distance)
    {
        return (distance / minutes) * 60;
    }

    public string GetSummary()
    {
        return $"{Date} Running ({minutes} min) - Distance: {Distance:F1} miles, Speed: {Speed:F1} min per mile";
    }

}



