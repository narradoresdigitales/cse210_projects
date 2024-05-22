public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected string _points = "0";

    protected bool _isComplete = false;

    protected Goal(string name, string description, string points) // constructor
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // public properties to access values in GoalManager
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    public string ShortName 
    {
        get {return _shortName;}
        //set { _shortName = value;}
    }

    public string Description 
    {
        get {return _description;}
        //set { _description = value;}
    }
    public string Points 
    {
        get {return _points;}
        //set { _points = value;}
    }



    public abstract void RecordEvent(); 


    public abstract bool IsComplete(); 


    public abstract string GetDetailsString();
    

    public abstract string GetStringRepresentation(); 
    

}