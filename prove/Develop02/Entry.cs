using System;
using System.IO;

public class Entry
{
    private string fileName = "journal.txt";
    private string _question = "";
    DateTime currentDate = DateTime.Now;
    List<string> saveUserEnter = new List<string>();

    // public string getQuestion()
    // {
    //     return _question;
    // }
    // public void setQuestion(string question)
    // {
    //     _question = question;
    // }

    public void _UserEntry()
    {
        // List<string> saveUserEnter = new List<string>();
        PromptGenerator rand = new PromptGenerator();
        rand.Prompt();
        
        // Console.Write("");
        var _answer = Console.ReadLine();
        if (_answer != null)
        {
            saveUserEnter.Add(_answer);
            foreach (var saves in saveUserEnter)
            {
                // Console.WriteLine(saves);
                using (StreamWriter SaveWrite = File.CreateText(fileName))
                {
                    // SaveWrite.WriteLine(saves);
                    SaveWrite.WriteLine($"date: {currentDate} -  {saves}");
               
                }
            }

        }
    }
    
    
    // public void Display()
    // {
    //     Console.WriteLine($"Today:{currentDate} ; {saveUserEnter}");
    // }
    
}