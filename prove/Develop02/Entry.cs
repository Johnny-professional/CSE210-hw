using System;
using System.IO;

class Entry
{
    public void Display()
    {
        int userChoise;
        // string _answer;
        List<string> listOfWritten = new List<string>();

        do
        {
        List<string> menuLists = new List<string>
        {
            "Please, select one of the Following Choises: ",
            "1. Write",
            "2.Display",
            "3.Load",
            "4.Save",
            "5.Quit"
            // "what would you like to do?"
        };
        
        
        Console.Write("what would you like to do? ");
        userChoise = int.Parse(Console.ReadLine());
        if (userChoise == 1)
        {
            foreach (var menuList in menuLists)
            {
                Console.WriteLine(menuList);
            }
            // Console.WriteLine(menuList);
            PromptGenerator rand = new PromptGenerator();
            rand.Prompt();
            var _response = new Journal();
            _response.UserEntry();
            
            
            // Console.WriteLine(menuLists);

            if (_response != null)
            {
                PromptGenerator rand1 = new PromptGenerator();
            rand1.Prompt();
            var _response1 = new Journal();
            _response1.UserEntry();
            }

        }
        else if (userChoise ==2)
        {
            
        }
        else if (userChoise ==3)
        {

        }
        else if (userChoise ==4)
        {

        }
        else
        {
            break;
        }

        





        
        
        
        // foreach (string listes in menuList)
        // {
        //     Console.WriteLine(listes);
            
        // }
        // userChoise = int.Parse(Console.ReadLine());
        }while(userChoise != 5);
   
    }

}