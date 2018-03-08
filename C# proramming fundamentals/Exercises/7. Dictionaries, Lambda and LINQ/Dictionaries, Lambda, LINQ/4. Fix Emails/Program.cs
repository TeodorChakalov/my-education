using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                string name = command;
                string email = Console.ReadLine();

                if (dict.ContainsKey(name) == false)
                {
                    dict.Add(name, email);
                }
                command = Console.ReadLine();
            }

            foreach (var pair in dict.Where(x => x.Value.EndsWith(".uk") == false && x.Value.EndsWith(".us") == false))
            {
                //if(!pair.Value.Contains(".uk") && !pair.Value.Contains(".us"))

                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}