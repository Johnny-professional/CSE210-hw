using System;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string StudentName, string Topic)
    {
        _studentName = StudentName;
        _topic = Topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string StudentName)
    {
        _studentName = StudentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string Topic)
    {
        _topic = Topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}