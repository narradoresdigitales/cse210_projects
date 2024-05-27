public class Comment

{
     // Set attributes
    public string _name { get;set; }
    public string _text { get;set; }


    public Comment (string name, string text)
    {
        _name = name;
        _text = text;
    
    }


    public void Display()
    {
        Console.WriteLine($"{_name} {_text}");
    }

}