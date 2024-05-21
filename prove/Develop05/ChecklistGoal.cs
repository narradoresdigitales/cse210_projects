public class ChecklistGoal : Goal

{
    public int _amountCompleted;
    public int _target;

    public int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points) {
    }

    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool IsComplete() {
        return _isComplete;
    }
    
    public override string GetStringRepresentation() {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}, IsComplete: {_isComplete}";
    }

    public override string GetDetailsString() {
        return $"Name: {_shortName}\nDescription: {_description}\nPoints: {_points}\n IsComplete: {_isComplete}";
    }


}



    