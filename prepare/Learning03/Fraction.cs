using System;

class Fraction{
    private int _top;
    private int _bottom;

    public void Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int num1 , int num2)
    {
        _top = num1;
        _bottom = num2;
    }

    public string GetFraction()
    {
        string Fra = $"{_top}/_bottom";
        return Fra;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom ;
    }


}