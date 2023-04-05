using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activity = new List<Activity>();

        Running running = new Running("06 April 2023", 30, "Running", 3);
        activity.Add(running);

        Bycicle cycling = new Bycicle("03 February 2023", 30, "Cycling", 3.9);
        activity.Add(cycling);

        SwimmingPool swimming = new SwimmingPool("16 january 2023", 30, "Swimming", 9);
        activity.Add(swimming);

        foreach (Activity act in activity)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}