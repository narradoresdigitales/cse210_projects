public class Swimming: Activity

{

    private double laps;

    public Swimming(string date, double laps): base(date)
    {
        this.laps = laps;
        Distance = GetDistance();
        double minutes = laps * 50 / 1000;
        Speed = GetSpeed(Distance, minutes);
        Pace = GetPace(laps, Distance);

    }

    public override double GetDistance()
    {
        
        return laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed(double distance, double minutes)
    {
        
        return (distance / minutes) * 60;
    }

    public override double GetPace(double laps, double distance)
    {
        double minutes = laps * 50 / 1000;
        return minutes / distance;
    }

    public string GetSummary()
    {
        return $"{Date} Swimming ({laps} laps) - Distance: {Distance: F1} miles, Speed: {Speed:F1} mph, Pace: {Pace:F1} min per mile";
    }


}