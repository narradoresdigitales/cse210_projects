public class WritingAssignment : Assignment 

{
    private string _title;

    public WritingAssignment (string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string name = GetStudent();
        return $"{_title} by {name}";
    }
}