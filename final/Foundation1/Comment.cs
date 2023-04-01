
using System;

public class Commnent
{
    public string _name= "";
    public string _comment ="";

    public List<string> _names = new List<string>();
    public List<string> _allcomments = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Comment({_names.Count()}): ");
        int i = 0;
        while(i < _names.Count())
        {  
            Console.WriteLine($"by {_names[i]}: '{_allcomments[i]}");
            i++;        
        };
        
    }

    
}