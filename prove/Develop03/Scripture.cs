using System;

class Scripture
{
    List<string> ListOfword = new List<string>();
    private string _bookName = "Proverb";
    private int _chapter = 3;
    private int _verse = 5;
    private int _endeVerse = 6;

    private string _Scripture = "Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";

    public string usingScripture()
    {
        return _Scripture;
    }
    
    public string GetReference()
    {
        return _bookName + _chapter +":" + _verse + "-" + _endeVerse;
    }

}

