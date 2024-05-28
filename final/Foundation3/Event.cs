/// <summary>
///   
/// All events need to have an Event Title, Description, Date, Time, and Address.
/// 
/// 
/// They would like the ability to generate three different messages:
///
/// Standard details - Lists the title, description, date, time, and address.
/// 
/// Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
/// 
/// Short description - Lists the type of event, title, and the date.
/// 
/// 
/// </summary>




public class Event

{
    public string Title {get; private set;}
    public string Description {get; private set;}

    public string Date {get; private set;}

    public string Time {get; private set;}

    public Address EventAddress {get; private set;}


    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public virtual string PublishStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: \n{EventAddress.GetFullAddress()}";
    }

    public virtual string PublishFullDetails()
    {
        return PublishStandardDetails();
    }

    public virtual string PublishShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }



}