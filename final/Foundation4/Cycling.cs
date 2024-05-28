public class Cycling:  Activity

{
    public double Duration {get; private set;}

    public Cycling(string date, double duration, double distance) : base(date, distance)
    {
        Duration = duration;
        Speed = GetSpeed(Distance, Duration);
        Pace = GetPace(Duration, distance);
    }

    public override double GetDistance()
    {
        return base.GetDistance();
    }

    public override double GetSpeed(double distance, double minutes)
    {
        return (distance / minutes) * 60;
    }

    public override double GetPace (double minutes, double distance)
    {
        return minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling ({Duration} min) - Distance: {Distance:F1} miles, Speed: {Speed:F1} Pace: {Pace:F1} min per mile";
    }







}