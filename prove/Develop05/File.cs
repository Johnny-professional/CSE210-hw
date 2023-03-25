using System;
using System.IO;

public class File
{
    private string FileName = "goals.txt";

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(FileName))
        {
         
        }
    }


}