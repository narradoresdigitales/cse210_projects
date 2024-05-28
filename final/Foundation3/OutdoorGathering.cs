/// <summary>
///  
/// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
/// 
/// 
/// </summary>

public class OutdoorGathering : Event

{

    public string WeatherStatement {get; private set;}

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        WeatherStatement = weatherStatement;
    }

    public override string PublishFullDetails()
    {
        return $"{base.PublishStandardDetails()}\nWeather: {WeatherStatement}";
    }

    
}