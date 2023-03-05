using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int numberFromUser = -1;
        do
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            numberFromUser = int.Parse(response);

            if ( numberFromUser != 0)
            {
                numbers.Add(numberFromUser);
            }
        } while (numberFromUser != 0);

        // the sum
        int sum = 0;
        foreach (int number in  numbers)
        {
            sum +=number;
        }
        Console.WriteLine($"the sum is: {sum}");

        // the avarage
        float avarage = ((float)sum) / numbers.Count;
        Console.WriteLine($"the avarage is: {avarage}");

    }

    
}