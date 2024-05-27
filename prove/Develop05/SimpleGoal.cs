public class SimpleGoal : Goal 

{
    
    public SimpleGoal(string name, string description, string points) : base(name, description, points) 
    {
    }

    // public override void RecordEvent() {
    //     _isComplete = true;

    //     int index _goals.FindIndex(global => global == this);
    //     if (index != -1)
    //     {
    //         _goals[index] = this;
    //     }
    // }

    public override bool IsComplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        
        string status = _isComplete ? "[X]" : "[ ]";
        return $" {status} {_shortName}, ({_description })";
    }


    public override string GetDetailsString() {
        return $" [ ] {_shortName} ({_description})";
    }

}