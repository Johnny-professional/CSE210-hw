using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // creat radom number from the computer
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // create loop
        int guess = -1;
        while (guess != magicNumber)
        {
        
            // ask the user to guess the number
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber < guess)
            {
                Console.WriteLine("higher");
            }
            else if (magicNumber >guess)
            {
                Console.WriteLine("lower");
            }
            else 
            {
                Console.WriteLine("you guessed it!");
            }
        }



        

    }
}