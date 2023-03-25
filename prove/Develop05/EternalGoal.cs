using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int completionPoints) : base(goal, description, completionPoints)
    {

    }

    public void AddValue2()
    {
        AddValue();
    }

    public override string Completed()
    {
        return $"[{_complet}] {_goal} ({_description})";
    }

    public override string DisplayGoal()
    {
        return $"{_goalType}: {_goal}, {_description}, {_completionPoints}";
    }
}

