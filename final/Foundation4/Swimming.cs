public class Swimming: Activity

{
    private double laps;

    public Swimming(string date, double laps) : base(date, laps * 50 / 1000 * 0.62)
    {
        this.laps = laps;
        double minutes = laps;
        Speed = GetSpeed(Distance, minutes);
        Pace = GetPace(minutes, Distance);

    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed(double distance, double minutes)
    {
        
        return (distance / minutes) * 60;
    }

    public override double GetPace(double minutes, double distance)
    {
        return minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({laps} laps) - Distance: {Distance: F1} miles, Speed: {Speed:F1} mph, Pace: {Pace:F1} min per mile";
    }


}