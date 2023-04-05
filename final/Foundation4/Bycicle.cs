using System;

public class Bycicle : Activity
{
    private double _speed;

    public Bycicle(string date, int length, string activity, double speed) : base(date,length,activity)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override double Distance()
    {
        return _length / Pace();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}