using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        List<Goal> GoalList = new List<Goal>();
        List<string> fileLists = new List<string>();
        List<int> numLists = new List<int>();
        List<string> nameLists = new List<string>();
        List<int> points = new List<int>();
        List<string> types = new List<string>();
        List<int> timesL = new List<int>();
        string filename1 = "";
        string filename = "";
        string check1 = " ";
        string check2 = " ";
        string check3 = " ";

        int finishedGoal = 0;
        int Choice = 0;
        int Done;
        int point = 0;
        // string UserEnter = "";
        int Choice1;
        string goal = "what is the name of you goal? ";
        
        
        string description = "what is a short description of it? ";
        
        int completionPoints = 0;
        

        
        do{
            Console.WriteLine();
            System.Console.WriteLine($"You have {point} point");
            System.Console.WriteLine();
            string[] MenuOption =
            {
                "   1. Create New Goal",
                "   2. Listes Goals",
                "   3. Save Goals",
                "   4. Load Goals",
                "   5. Record Events",
                "   6. Quit",
                "Select a choice from the menu: "
            };
            foreach (string _menu in MenuOption)
            {
                Console.WriteLine(_menu);
            }
            Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                string[] GoalChoices = 
                {
                    "The type of Goal are: ",
                    "   1. Simple Goal ",
                    "   2. Eternal Goal",
                    "   3. CheckList Goal",
                    "which type of Goal would you like to create? "
                };
                foreach(string _goalChoice in GoalChoices)
                {
                    Console.WriteLine(_goalChoice);
                }
                Choice1 = int.Parse(Console.ReadLine());
                
                if (Choice1 == 1)
                {
                    SimpleGoal _simpleGoal = new SimpleGoal(goal, description, completionPoints);
                    _simpleGoal.SetGoalType("simple Goal: ");
                    _simpleGoal.AddValue1();
                    GoalList.Add(_simpleGoal);
                }
                if (Choice1 == 2)
                {
                    EternalGoal _eternalGoal = new EternalGoal(goal, description, completionPoints);
                    _eternalGoal.SetGoalType("Eternal Goal:");
                    _eternalGoal.AddValue2();
                    GoalList.Add(_eternalGoal);
                }
                if (Choice1 == 3)
                {
                    ChecklistGoal _checkListGoal = new ChecklistGoal(goal, description, completionPoints);
                    _checkListGoal.SetGoalType("Checklist Goal: ");
                    _checkListGoal.AddValue3();
                    GoalList.Add(_checkListGoal);
                }
                
            }
            else if(Choice == 2)
            {
                int fileCount = fileLists.Count();

                Console.WriteLine("The goals are:");

                if (fileCount == 0)
                {
                foreach (Goal goal1 in GoalList)
                    {
                        int index = GoalList.IndexOf(goal1);
                        Console.WriteLine($"{index + 1}. {goal1.Completed()}");
                    } 
                }else
                {
                    string openFile = fileLists[0];
                    string[] lines = System.IO.File.ReadAllLines(openFile);
                    int i = 1;
                    foreach (string line in lines)
                    {
                        Char[] myChars = {',',':'};
                        string[] parts = line.Split(myChars);
                        string goalType = parts[0];
                        if (goalType == "0")
                        {}
                        else{
                        string name = parts[1];
                        string description1 = parts[2];
                        int amountPoints = int.Parse(parts[3]);

                        Console.Write($"{i}. ");
                        types.Add(goalType);
                        numLists.Add(i);
                        nameLists.Add(name);
                        points.Add(amountPoints);
                        if (line == "0")
                        {}
                        else {
                        if (goalType == "SimpleGoal")
                        {
                            Console.WriteLine($"[{check1}] {name} ({description})");
                        }else if (goalType == "EternalGoal")
                        {
                            Console.WriteLine($"[{check2}] {name} ({description})");
                        }else if (goalType == "ChecklistGoal")
                        {
                            int bonus = int.Parse(parts[4]);
                            int times = int.Parse(parts[5]);
                            timesL.Add(times);
                            int done = int.Parse(parts[6]);
                            Done = done;

                            Console.WriteLine($"[{check3}] {name} ({description}) -- Currently Completed: {done}/{times}");
                        }
                        
                        i++;
                        }
                    }
                    
                }
                }
            }
            else if (Choice == 3)
        {
            Console.Write("What is the filename for the goal? ");
            filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"{point}");
                foreach (Goal goal1 in GoalList)
                {
                    outputFile.WriteLine($"{goal1.DisplayGoal()}");
                }
                
            }

        }

        else if (Choice == 4)
        {
            Console.Write("What is the filename of the goal file? ");
            filename1 = Console.ReadLine();
            fileLists.Add(filename1);
        }

        else if (Choice == 5)
        {
            Console.WriteLine("Which goal did you accomplish? ");
            int goalDone = int.Parse(Console.ReadLine());
            foreach (int num in numLists)
            {
                if (num == goalDone)
                {
                    int index = numLists.IndexOf(num);
                    int newPoint = points[index];
                    point = point + newPoint; 
                    if (types[index] == "SimpleGoal")
                    {
                        check1 = "X";
                        Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                        Console.WriteLine($"You now have {point} points");
                    } else if (types[index] == "EternalGoal")
                    {
                        check2 = "";
                        Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                        Console.WriteLine($"You now have {point} points");
                    }else if (types[index] == "ChecklistGoal")
                    {
                        finishedGoal = finishedGoal + 1;
                        Done = finishedGoal;
                        if (Done <= timesL[0])
                        {
                            Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                            Console.WriteLine($"You now have {point} points");
                        } else 
                        {
                            check3 = "X";
                            Console.WriteLine("Bingo!!");
                            Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                            Console.WriteLine($"You now have {point} points");
                        }
                        
                    }
                }
            }

        }
            


        }while(Choice != 6);



    }
}