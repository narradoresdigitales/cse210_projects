public class Goal

{

    public string _shortName = "";
    public string _description = "";
    public string _points = "0";


    public Goal(string name, string description, string points) // constructor
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
    }

    // public bool IsComplete()
    // {
    //     return IsComplete;
    // }

    // public string GetDetailsString()
    // {
    // }

    // public string GetStringRepresentation()
    // {
    // }



}