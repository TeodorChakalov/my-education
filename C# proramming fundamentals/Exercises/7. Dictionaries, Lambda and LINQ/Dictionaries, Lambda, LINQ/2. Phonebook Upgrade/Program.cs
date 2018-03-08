using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split(' ');

                if (commandArgs[0] == "A")
                {
                    string name = commandArgs[1];
                    string phoneNumber = commandArgs[2];

                    if (dict.ContainsKey(name) == false)
                    {
                        dict.Add(name, phoneNumber);
                    }
                    else
                    {
                        dict[name] = phoneNumber;
                    }
                }
                else if (commandArgs[0] == "S")
                {
                    string name = commandArgs[1];

                    if (dict.ContainsKey(name) == false)
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", name, dict[name]);
                    }
                }
                else if(commandArgs[0] == "ListAll")
                {
                    foreach (var pair in dict.OrderBy(x => x.Key))
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}