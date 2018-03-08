using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>>  dict= new Dictionary<string, Dictionary<string, int>>();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "end")
            {
                string[] ipInput = command[0].Split('=').ToArray();
                string ip = ipInput[1];
                string[] userInput = command[2].Split('=').ToArray();
                string user = userInput[1];

                if(dict.ContainsKey(user) == false)
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    dict.Add(user, current);
                }
                else
                {
                    if(dict[user].ContainsKey(ip) == false)
                    {
                        dict[user].Add(ip, 1);
                    }
                    else
                    {
                        dict[user][ip]++;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }

            foreach (var currentUser in dict.OrderBy(x => x.Key))
            {
                List<string> helper = new List<string>();
                Console.WriteLine("{0}: ", currentUser.Key);
                foreach (var pair in currentUser.Value)
                {
                    helper.Add($"{pair.Key} => {pair.Value}");
                }
                Console.WriteLine(string.Join(", ", helper) + ".");
            }           
        }
    }
}