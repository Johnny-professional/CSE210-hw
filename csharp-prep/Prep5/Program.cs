using System;

class Program
{
    static void Main(string[] args)
    {
        
        WelcomeUserMessage();

        string takeUserName = UserName();
        int takeUserNumber = UserNumber();

        int FavoriteNumber = SquareNumber(takeUserNumber);

        ResultTest(takeUserName,FavoriteNumber);
       
    }
    static void WelcomeUserMessage()
    {
        Console.WriteLine("welcome to the program");
    }
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }
    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void ResultTest(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your favorite number is: {number}");
    }




}