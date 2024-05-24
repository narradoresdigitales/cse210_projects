public class EternalGoal : Goal
{

    public  EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    
    }
    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $" [ ] {_shortName} ({_description})";
    }

    public override string GetDetailsString() {
        
        return $" [ ] {_shortName} ({_description})";
    }

} 