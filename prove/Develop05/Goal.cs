using System;

public abstract class Goal
{
    protected string _goal = "";
    protected string _description = "";

    protected int _completionPoints;

    protected string _complet = " ";
    protected string _goalType = "";
    
    public string GetGoalType()
    {
        return _goalType;
    }
    
    public void SetGoalType(string  goalType)
    {
        _goalType = goalType;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetCompletionPoints()
    {
        return _completionPoints;
    }
    public void SetCompletionPoints(int completionPoints)
    {
        _completionPoints = completionPoints;
    }

    public Goal(string goal, string description, int completionPoints)
    {
        _goal = goal;
        _description = description;
        _completionPoints = completionPoints;
    }

    public void AddValue()
    {
        Console.Write("what is the name of you goal? ");
        _goal =Console.ReadLine();
        
        Console.Write("what is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("what is the amount of points associated with this goal? ");
        _completionPoints = int.Parse(Console.ReadLine());

    }

    // public virtual string ListGoals()
    // {
    //     return $"[{_complet}] {_goal} ({_description})";
    // }

    public abstract string Completed();
    // {
    //     return $"[{_complet}] {_goal} {_description}";
    // }

    public abstract string DisplayGoal();
    


     
}