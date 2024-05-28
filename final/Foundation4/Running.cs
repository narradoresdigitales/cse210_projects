using System;
using System.Security.Cryptography.X509Certificates;
public class Running: Activity

{
    public double Duration {get; private set;} 

    public Running(string date, double duration, double distance): base(date, distance)
    {
        Duration = duration;
        Speed = GetSpeed(Distance, Duration);
        Pace = GetPace(Duration, Distance);

    }

        public override double GetDistance()
        {
            return Distance;
        }

    public override double GetPace(double minutes, double distance)
    {
        return (distance / minutes) * 60;
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({Duration} min) - Distance: {Distance:F1} miles, Speed: {Speed:F1} min per mile";
    }

}



