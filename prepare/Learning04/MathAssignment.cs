public class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string student, string topic, string textbookSection, string problems) : base(student, topic)
    {
        _textbookSection = section;
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }


}
