using System;
using System.IO;

public class Entry
{
    private string fileName = "journal.txt";
    DateTime currentDate = DateTime.Now;
    List<string> saveUserEnter = new List<string>();
    public void _UserEntry()
    {
        // List<string> saveUserEnter = new List<string>();
        Console.Write("");
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
                    SaveWrite.WriteLine($"date: {currentDate} - {saves}");
               
                }
            }

        }
    }
    
    
    // public void Display()
    // {
    //     Console.WriteLine($"Today:{currentDate} ; {saveUserEnter}");
    // }
    
}