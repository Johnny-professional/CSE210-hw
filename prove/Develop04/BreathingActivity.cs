using System;

public class Breathing : Activity
{
    private string _in = "";
    private string _out = "";

    public Breathing(int duration, string name) : base (duration, name)
    {
        _in = "Breath in...";
        _out = "Breath out...";

    }

    public string GetIn()
    {
        return _in;
    }

    public void setIn(string breathIn)
    {
        _in = breathIn;
    }

    public string GetOut()
    {
        return _out;
    }

    public void SetOut(string breathOut)
    {
        _out = breathOut;
    }

    

    public void displayBreathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime  = startTime.AddSeconds(_duration);

        // DateTime currentDate = DateTime.Now;
        while( startTime < endTime)
        {
            Console.Write(_in);
            int a = 4;
            while(a>=1)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                a--;
            }
            int b = 6;
            Console.Write(_out);
            while( b>=1)
            {
                Console.Write($"{b}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                b--;
            }
            Console.WriteLine();
            Console.WriteLine();

            DateTime timeNow = DateTime.Now;
            startTime = timeNow;
        }

        
    }




}