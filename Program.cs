using System;
using System.Collections.Generic;

namespace phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dic
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            
            string response = "";
            // force lowercase 
            while (response.ToLower() != "exit")
            {
                Console.WriteLine("Please enter a name for ur own personal phonebook");
                string name = Console.ReadLine();

                Console.WriteLine("Also Please enter a phone number for daniel's phonebook");
                string number = Console.ReadLine();
                //keys
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                    Console.WriteLine("You have just updated your contact called " + name + " ->" + number);

                }
                else
                {
                    phonebook.Add(name, number);
                    Console.WriteLine("You have just added your new contact called " + name + " ->" + number);

                }

                // let search
                Console.WriteLine("type search to look up ur contact or exit to leave");
                response = Console.ReadLine();
                if (response.ToLower() == "search")
                {
                    Console.WriteLine("please enter the name u wanna look up");
                    string searches = Console.ReadLine();
                    //search
                    if (phonebook.ContainsKey(searches))
                    {
                       
                        Console.WriteLine("this is what our entries have found in ur phonebook, name: " + searches + " & their number: " + phonebook[searches]);
                    }
                    else
                    {
                        Console.WriteLine(" sorry contact " + searches + " DNE, please check the spelling or info about the contact & retry again");
                    }

                }
            }
        }
    }
}
      
  
    

