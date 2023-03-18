using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        // string _in = "breath in...";
        // DateTime startTime = DateTime.Now;
        // DateTime endTime  = startTime.AddSeconds(30);

        // DateTime currentDate = DateTime.Now;
        // while( currentDate < endTime)
        // {
        //     Console.Write(_in);
        //     int a = 4;
        //     while(a>=1)
        //     {
        //         Console.Write(a);
        //         Thread.Sleep(1000);
        //         Console.Write("\b \b");
        //         a--;
        //     }
        // }

        // List<string> animation = new List<string>();
        // Person Myact = new Person();
        // var b = Myact.MyName();
        // Console.Write(b);
        

        // //  |/-\|

        // animation.Add("|");
        // animation.Add("/");
        // animation.Add("-");
        // animation.Add("\\");
        // // animation.Add("|");
        // animation.Add("|");
        // animation.Add("/");
        // animation.Add("-");
        // animation.Add("\\");
        // animation.Add("|");

        // DateTime startTime = DateTime.Now;
        // DateTime futureTIme = startTime.AddSeconds(10);

        // int i = 0;

        // while(DateTime.Now < futureTIme)
        // {
        //     string s = animation[i];
        //     // Console.Write(s);
        //     // Thread.Sleep(1000);
        //     // Console.Write("\b \b");
        //     i++;

        //     if (i>= animation.Count)
        //     {
        //         i = 0;
        //     }
        // }


        // // int i = 0;

        // // foreach (string myanimation in animation)
        // // {
        // //     Console.Write(myanimation);
        // //     Thread.Sleep(1000);
        // //     Console.Write("\b \b");
        // // }

        // System.Console.WriteLine("done" );
        int user_choice;

        do{
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");

        Console.Write("Select a choice from the menu: ");
        user_choice = int.Parse(Console.ReadLine());
        Console.Clear();

        if (user_choice == 1)
        {
            string description = "This activity will help you relay by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            Activity a1 = new Activity(description, "Breathing Activity");
            Console.WriteLine(a1.DisplayActivity());
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session(10, 20, 30, 40 ...)? ");
            int delay = int.Parse(Console.ReadLine());
            Console.Clear();

            Breathing breathing = new Breathing(delay, "Breathing Activity");
            breathing.GetReady();
            breathing.displayBreathing();
            breathing.Ending();
            
        }

        if (user_choice == 2)
        {
            string description = "This activity will help youreflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

            Activity a2 = new Activity(description, "Reflecting Activity");
            Console.WriteLine(a2.DisplayActivity());
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            int delay = int.Parse(Console.ReadLine());
            Console.Clear();

            Reflecting reflecting = new Reflecting(delay, "Reflecting Activity");
            reflecting.GetReady();
            reflecting.StartReflecting();
            reflecting.Ending();


        }

        if (user_choice == 3)
        {
            string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

            Activity a3 = new Activity(description, "Listing Activity");
            Console.WriteLine(a3.DisplayActivity());
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            int delay = int.Parse(Console.ReadLine());
            Console.Clear();

            Listing listing = new Listing(delay, "Listing Activity");
            listing.GetReady();
            listing.StartListing();
            listing.Ending();

        }
        
        } while (user_choice != 4);
    }
        
    
}