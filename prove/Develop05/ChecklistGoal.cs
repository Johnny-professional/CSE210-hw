using System;

public class ChecklistGoal : Goal
{
    private int _timesDone;
    private int _timeToComplete;
    private int _bonusPoints;

    public int GetTimeDone()
    {
        return _timesDone;
    }

    public void SetTimesDone(int timesDone)
    {
        _timesDone = timesDone;
    }

    public int GetBonus()
    {
        return _bonusPoints;
    }

    public void SetBonus(int bonus)
    {
        _bonusPoints = bonus;
    }

    public void AddValue3()
    {
        AddValue();
        Console.Write("how many times does this goal need to be accomplished for a bonus? ");
        _timeToComplete = int.Parse(Console.ReadLine());
        Console.Write("what is the bonus for accomplshing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }


    public ChecklistGoal(string goal, string description, int DonePoint ): base (goal, description, DonePoint)
    {
        // _timesDone = DonePoint;
    }

    public override string Completed()
    {
        return $"{_complet} {_goal} ({_description})";
    }

    public override string DisplayGoal()
    {
        return $"[{_goalType}]: {_goal}, {_description}, {_completionPoints}, {_bonusPoints}, {_timeToComplete}" ;
    }
  
}