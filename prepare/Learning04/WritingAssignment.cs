using System;

public class WritingAssignment: Assignment
{
    private string _tittle = "";
    public WritingAssignment(string StudentName, string Topic, string Tittle): base(StudentName, Topic)
    {  
        _tittle = Tittle;

    }

    
    
    public string GetTitte()
    {
        return _tittle;   
    }
    public void SetTittle(string Tittle)
    {
        _tittle = Tittle;
    }

    public string GetWritingInformation()
    {
        return _tittle;
    }
}

