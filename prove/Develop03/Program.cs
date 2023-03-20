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
        
        while (UserChoice != "quit")
        {
            List<string> wordList = new List<string>();
        
            Word _enter = new Word();
            string _getEnter = _enter.GetEnter();
            // string _theText = _enter.GetText();
            // var TheScripture = new Scripture();
            // var _scripture = TheScripture.usingScripture();
            // var _UserEnter = TheScripture.usingScripture();
            // Console.WriteLine(_scripture);
            Console.WriteLine(_getEnter);
            Console.ReadLine();
            Console.Clear();

            
            char[] chars = new char[] {';','.',',',' '};
            // var text = new Word();
            var Mytext = _enter.GetText();
            string[] _split = Mytext.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            foreach ( string x in _split )
            {
                wordList.Add(x);
            }
            Random random = new Random();
            int CountWord = wordList.Count();
            int _number = random.Next(0, CountWord);
            int _number1 = random.Next(0, CountWord);
            int _number2 = random.Next(0, CountWord);

            NewList.Add(_number);
            NewList.Add(_number1);
            NewList.Add(_number2);

            int numberCount = NewList.Count();
            string  _hiddenword = "";


            foreach (int _element in NewList)
            {
                string PickedWord = wordList[_element];
                int _number3 = PickedWord.Count();
                int i = 0;  
                
                while (i < _number3)
                {
                    _hiddenword = _hiddenword + "_";
                    i++;
                } 
                wordList[_element] = _hiddenword;
                _hiddenword = "";
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

    

        }
      
    } 
    
        
    

}