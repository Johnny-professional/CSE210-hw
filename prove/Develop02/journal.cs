using System;
using System.IO;

public class Journal
{
    // DateTime _dateTime = DateTime.Now;
    // string filename = "journal.txt";
    string userWriter;
    string _question;
    string _dateTime;
    string _answer;
    List<Entry> entreis = new List<Entry>();
    List<string> _load = new List<string>();

    // List<string> listOfWritten = new List<string>();
    

    public void DisplayJournalEntries()
    {
        Console.WriteLine($"date: {_dateTime} Prompt: {_question}");
        Console.WriteLine($"- {_answer}");
    }

    public void SaveToFile()
    {
        // using (userWriter outputFile = new userWriter(filename))
        // {outputFile.WriteLine();}
        
    }

    public void LoadFromFile()
    {
        Console.Write("what is the filename? ");
        string files = Console.ReadLine();
        _load.Add(files);

        // string files = "journal.txt";
        // string[] lines = System.IO.File.ReadAllLines(files);
        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");
        //     Console.WriteLine(line);
        // }
    }

    public void Display1()
    {
        string files = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(files);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
    }
    public void SaveIntoFile()
    {
        Console.Write("what is the filename? ");
        string files = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(files))
        {
            outputFile.Write($"{entreis}");
            foreach (Entry _entry in entreis)
            {
                outputFile.Write($"{_entry._UserEntry}");
            }

        }

    }

}
