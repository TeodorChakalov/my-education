using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input != "Lumpawaroo")
            {

                if (input.Contains("|"))
                {
                    string[] tokens = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    string forceSide = tokens[0];
                    string forceUsers = tokens[1];

                    string nameColor = $"{forceSide} | {forceUsers}";

                    if (dict.ContainsKey(forceUsers) == false)
                    {
                        dict.Add(forceUsers, forceSide);
                    }
                }
            }

        }
    }
}