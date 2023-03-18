using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment(string StudentName, string Topic, string TextBookSection, string Problems): base(StudentName, Topic)
    {
        _textBookSection = TextBookSection;
        _problems = Problems;
    }
    public string GetTextBookSection()
    {
        return _textBookSection;
        
    }
    public void SetTextBookSection(string TextBookSection)
    {
        _textBookSection = TextBookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblmes(string Problems)
    {
        _problems = Problems;
    }
    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection}, Priblem:{_problems}";
    }
}