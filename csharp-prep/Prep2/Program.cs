using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("enter you grade(%) : ");
        string valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);

        if (x >= 90)
        {
            Console.WriteLine("your grade is A");
        }
        else if (x >=80)
        {
            Console.WriteLine("your grade is B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("your grade is c");
        }
        else
        {
            Console.WriteLine("your grade is F");
        }
    }   

}