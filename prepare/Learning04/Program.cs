using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        // Assignment Assignment1 = new Assignment("Johnny", "Multi");
        // Assignment1.SetStudentName("johnny");
        // Assignment1.SetTopic("Multi");

        // System.Console.WriteLine(Assignment1.GetSummary());


        MathAssignment Math1 = new MathAssignment("Roberto Johnny", "science", "7.3", "8/5, 6-5, 7*4, 534+56 = ?");
        Math1.SetStudentName("Roberto Johnny");
        Math1.SetTopic("sceince");
        Math1.SetTextBookSection("7.3");
        Math1.SetProblmes("8/5, 6-5, 7*4, 534+56 = ?");

        System.Console.WriteLine(Math1.GetSummary());
        System.Console.WriteLine(Math1.GetHomeWorkList());

        System.Console.WriteLine("-----------------------------------------------------------------------------------------");

        WritingAssignment Writing1 = new WritingAssignment("Nancy H.","History", "The cause of the world war II in 1945");
        Writing1.SetStudentName("Nancy H.");
        Writing1.SetTopic("History");
        Writing1.SetTittle("The cause of the world war II in 1945");

        System.Console.WriteLine(Writing1.GetSummary());
        System.Console.WriteLine(Writing1.GetWritingInformation());
      

    }
}