public class ChecklistGoal : Goal

{
    public int AmountCompleted {get; set;}
    public int Target {get; private set;}

    public int Bonus {get; private set;}

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points) 
    
    {
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
        _isComplete = false;
    }

    
    public override void RecordEvent() {
        AmountCompleted++;
        if(AmountCompleted >= Target)
        {
            _isComplete = true;
            int totalPoints = int.Parse(_points) + Bonus;
            _points = totalPoints.ToString();
        }
    }

    public override bool IsComplete() {
        return _isComplete;
    }
    
    public override string GetStringRepresentation() {
        return $" [ ] {_shortName}, ({_description}) --- Currently completed: {AmountCompleted} / {Target}"; 
    }

    public override string GetDetailsString() {
        return $"[ ] {_shortName} ({_description}) --- Currently completed: {AmountCompleted} / {Target}";

    }


}



    