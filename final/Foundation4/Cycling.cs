public class Cycling:  Activity

{
    private double minutes;

    public Cycling(string date, double distance, double minutes) : base(date, distance)
    {
        this.minutes = minutes;
        Speed = GetSpeed(distance, minutes);
        Pace = GetPace(minutes, distance);
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

    public string GetSummary()
    {
        return $"{Date} Cycling ({minutes} min) - Distance: {Distance:F1} miles, Speed: {Speed:F1} Pace: {Pace:F1} min per mile";
    }







}