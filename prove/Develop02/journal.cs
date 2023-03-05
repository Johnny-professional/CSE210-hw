using System;

class Journal
{
    // DateTime _dateTime = DateTime.Now;
    string filename = "journal.txt";
    string userWriter;
    string _question;
    string _dateTime;
    string _answer;
    // List<Entry> entreis;

    // List<string> listOfWritten = new List<string>();
    public void UserEntry()
    {
        Console.Write("");
        var _answer = Console.ReadLine();

    }

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

    }

}