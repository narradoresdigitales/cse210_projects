public class ChecklistGoal : Goal

{
    public int _amountCompleted;
    public int _target;

    public int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points) 
    
    {
        _bonus = bonus;
        _target = target;
        
    }

    
    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool IsComplete() {
        return _isComplete;
    }
    
    public override string GetStringRepresentation() {
        return $" [ ]{_shortName}, ({_description})";
    }

    public override string GetDetailsString() {
        return $" [ ] {_shortName} ({_description}) --- Currently completed: {_amountCompleted} / {_target}";

    }


}



    