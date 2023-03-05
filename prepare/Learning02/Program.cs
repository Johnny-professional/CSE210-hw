using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Engeneer";
        job1._startYear = 1999;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._companyName = "Appel";
        job2._jobTitle = "Manager";
        job2._startYear = 1965;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Roberto Johnny";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}