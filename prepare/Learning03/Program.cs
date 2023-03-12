using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        var Fraction1 = new Fraction();
        Console.WriteLine(Fraction1.GetFraction());
        Console.WriteLine(Fraction1.GetDecimalValue());

        var Fraction2 = new Fraction(5);
        Console.WriteLine(Fraction2.GetFraction());
        Console.WriteLine(Fraction2.GetDecimalValue());

        var Fraction3 = new Fraction(3,4);
        Console.WriteLine(Fraction3.GetFraction());
        Console.WriteLine(Fraction3.GetDecimalValue));

        var Fraction4 = new Fraction(1,3);
        Console.WriteLine(Fraction4.GetFraction());
        Console.WriteLine(Fraction4.GetDecimalValue());






    }
}