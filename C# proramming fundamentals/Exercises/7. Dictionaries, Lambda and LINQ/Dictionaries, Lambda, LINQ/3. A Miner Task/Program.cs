using System;
using System.Collections.Generic;

namespace _3.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while(command != "stop")
            {
                string recource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(recource) == false)
                {
                    dict.Add(recource, quantity);
                    // dict[recource] = quantity;
                }
                else
                {
                    dict[recource] += quantity;
                }
                command = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}