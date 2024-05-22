public class SimpleGoal : Goal 

{
    
    public SimpleGoal(string name, string description, string points) : base(name, description, points) 
    {
    }

    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool IsComplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        return $" [X] {_shortName}, ({_description })";
    }


    public override string GetDetailsString() {
        return $" [ ] {_shortName} Description: {_description}";
    }

}