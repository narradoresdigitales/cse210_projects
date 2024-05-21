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
        return $"Name: {_shortName}\nDescription: {_description}\nPoints: {_points}\n IsComplete: {_isComplete}";
    }

    public override string GetDetailsString() {
        return $"Name: {_shortName}\nDescription: {_description}\nPoints: {_points}\n IsComplete: {_isComplete}";
    }

} 