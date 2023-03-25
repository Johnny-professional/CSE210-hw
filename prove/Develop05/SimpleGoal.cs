using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points) : base (goal, description, points)
    {

    }
    public void AddValue1()
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