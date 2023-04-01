using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;
    public List<Commnent> Commentes = new List<Commnent>();


    public void infoVideo()
    {
        Console.WriteLine($" video: {_title} - by {_author} (in {_length} s)");
        foreach( Commnent _commnents in Commentes)
        {
            _commnents.Display();
        } 
        
        Console.WriteLine();

    }
}