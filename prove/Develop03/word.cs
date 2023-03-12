using System;

public class Word
{
    private string _text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";
    private string _enter ="Press Enter to continue or 'quit' to finish: ";

    public string _first;
    public string _second;
    public string _third;
    public string _fourth;
    public string _fifth;
    public string _last;
    

    public string GetText()
    {
        return _text;
    }

    public string GetEnter()
    {
        return _enter;
    }

    public string  NumberString()
    {
        return _first + _second + _third + _fourth + _fifth + _last;
    }
    
    

    // public string SplitText()
    // {
    //     string[] _splitText = _text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
    //     return _text;  
    // }
   

}



