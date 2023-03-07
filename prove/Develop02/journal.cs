using System;

public class Journal
{
    // DateTime _dateTime = DateTime.Now;
    // string filename = "journal.txt";
    string userWriter;
    string _question;
    string _dateTime;
    string _answer;
    // List<Entry> entreis;

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
        string files = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(files);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
    }

}
