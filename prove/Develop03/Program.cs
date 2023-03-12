using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> NewList = new List<int>();
        string UserChoice = "";
        var TheScripture = new Scripture();
        var _scripture = TheScripture.usingScripture();
        Console.WriteLine(_scripture);
        
        do{

        
            
            // var TheScripture = new Scripture();
            // var _scripture = TheScripture.usingScripture();
            var _UserEnter = TheScripture.usingScripture();
            // Console.WriteLine(_scripture);
            Console.WriteLine(_UserEnter);
            Console.ReadLine();
            Console.Clear();

            List<string> wordList = new List<string>();
            
            char[] chars = new char[] {';','.',',',' '};
            var text = new Word();
            var Mytext = text.GetText();
            string[] _split = Mytext.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            foreach ( var x in _split )
            {
                wordList.Add(x);
            }
            Random random = new Random();
            int CountWord = wordList.Count();
            int _number = random.Next(0, CountWord);
            int _number1 = random.Next(0, CountWord);
            NewList.Add(_number);
            NewList.Add(_number1);

            foreach (int _element in NewList)
            {
                var PickedWord = wordList[_element];
                var _number3 = PickedWord.Count();
                var hidden = 0;
                
                while (hidden< _number3)
                {
                    PickedWord = PickedWord + "_";
                    hidden++;
                } 
                PickedWord = "";
            }
            int j = 0;
            string part1 = "";
            while (j < 14)
            {
                part1 = part1 + wordList[j] + " ";
                j++;
            }

            string part2 = wordList[14] + "; ";

            int k = 15;
            string part3 = "";
            while (k < 20)
            {
                part3 = part3 + wordList[k] + " ";
                k++;
            }

            string part4 = wordList[20] + ", ";

            int l = 21;
            string part5 = "";
            while (l < (CountWord-1))
            {
                part5 = part5 + wordList[l] + " ";
                l++;
            }

            string part6 = wordList[CountWord -1] + ".";

            var all = new Word();
            all._first = part1;
            all._second = part2;
            all._third = part3;
            all._fourth = part4;
            all._fifth = part5;
            all._last = part6;

            string combined = all.NumberString();
            var Script = new Scripture();
            var reference = Script.GetReference();


            Console.WriteLine(reference + combined);

        



        }while (UserChoice != "quit");
    } 
    
        
    

}