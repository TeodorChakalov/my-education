using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');

                string ip = commandArgs[0];
                string user = commandArgs[1];
                int duration = int.Parse(commandArgs[2]);

                if(dict.ContainsKey(user) == false)
                {
                    Dictionary<string, int> helper = new Dictionary<string, int>();
                    helper.Add(ip, duration);
                    dict.Add(user, helper);
                }
                else
                {
                    if(dict[user].ContainsKey(ip) == false)
                    {
                        dict[user][ip] = 0;
                    }
                    dict[user][ip] += duration;
                }
            }
            foreach (var pair in dict.OrderBy(x => x.Key)) // не мога да сортирам едновременно 2 различни колекции
            {
                string[] ips = pair.Value.Keys.OrderBy(x => x).ToArray();
                Console.WriteLine("{0}: {1} [{2}]", pair.Key, pair.Value.Values.Sum(), string.Join(", ",ips));
            }
        }
    }
}