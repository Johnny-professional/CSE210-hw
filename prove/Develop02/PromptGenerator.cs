using System;

public class PromptGenerator
{
   private string[] randQuestion =
    {
        "- Who was the most interesting person I interacted with today? ",
        "- What was the best part of my day?",
        "- How did I see the hand of the Lord in my life today? ",
        "- What was the strongest emotion I felt today? ",
        "- If I had one thing I could do over today, what would it be? ",
        "- what was the new things I learned Today? ",
        "- what is the things I need to improve? "
    };
    string _randomFirst = "";

    public string GetRand()
    {
        return _randomFirst;
    }

   public void Prompt()
   {
    // _randomFirst = _randomFirst;

    Random PromptGenerator = new Random();
    string randomFirst = randQuestion[PromptGenerator.Next(randQuestion.Length)];

    Console.WriteLine(randomFirst);
    Console.Write("");
    
   }


}
