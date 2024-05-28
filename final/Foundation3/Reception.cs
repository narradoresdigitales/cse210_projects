

using System.ComponentModel;

/// <summary>
/// 
/// Receptions, which require people to RSVP, or register, beforehand.
/// 
/// </summary>
public class Reception : Event

{
    public string RSVPEmail {get; private set;}

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string PublishFullDetails()
    {
        return $"{base.PublishStandardDetails()}\nRSVP Email: {RSVPEmail}";
    }


}