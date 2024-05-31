

using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;

/// <summary>
///  
/// Lectures, which have a speaker and have a limited capacity.
/// 
/// 
/// </summary>
public class Lecture : Event

{
    
    public string Speaker {get; private set;}

    public int Capacity {get; private set;}

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity ) : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string PublishFullDetails()
    {
        return $"{base.PublishStandardDetails()}\nSpeaker: {Speaker}\nCapacity {Capacity}";
    }

    public override string PublishShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }

}