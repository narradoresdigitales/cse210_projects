using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string _date;
    
    public string _promptText;


    public string _entryText;


    public void Display(string date, string text)
    {
        Console.WriteLine($"You have recorded {text} on {date}");
    }
}