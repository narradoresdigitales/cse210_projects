public class SimpleGoal : Goal 

{

    public bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    // public void RecordEvent()
    // {
    // }

    // public bool IsComplete()
    // {
    // }

    // public string GetStringRepresentation()
    // {
    // }

}