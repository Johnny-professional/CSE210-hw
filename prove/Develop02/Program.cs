using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        int userChoise = 0;
        
        List<string> menuLists = new List<string>
        {
            "Please, select one of the Following Choises: ",
            "1. Write",
            "2.Display",
            "3.Load",
            "4.Save",
            "5.Quit",
            "what would you like to do?"
        };
        
        
        Console.WriteLine("welcome to the Journal.");
        // userChoise = int.Parse(Console.ReadLine());
        do
        {
            foreach (var menuList in menuLists)
            {
                Console.WriteLine(menuList);
            }
            // Console.WriteLine(menuList);
            userChoise = int.Parse(Console.ReadLine());
            if (userChoise ==1)
            {
                PromptGenerator rand = new PromptGenerator();
                rand.Prompt();
                var _response = new Entry();
                _response._UserEntry();

            }
            else if (userChoise == 2)
            {
                var _journals = new Journal();
                _journals.LoadFromFile();
                

            }

            else if (userChoise == 3)
            {
                
            }
            
            else if (userChoise == 4)
            {
                
            }

            
            
            // Console.WriteLine(menuLists);

            

        }while (userChoise != 5);
        

        





        
        
        
        // foreach (string listes in menuList)
        // {
        //     Console.WriteLine(listes);
            
        // }
        // userChoise = int.Parse(Console.ReadLine());
        
   
    }

}
        
        