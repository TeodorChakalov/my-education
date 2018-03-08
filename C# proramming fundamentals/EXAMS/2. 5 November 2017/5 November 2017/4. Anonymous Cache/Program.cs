using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] commandArgs = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs.Length == 1)
                {
                    string dataSet = commandArgs[0];
                    if (dict.ContainsKey(dataSet) == false)
                    {
                        dict[dataSet] = new Dictionary<string, long>();
                    }
                }
                else
                {
                    string dataKey = commandArgs[0];
                    long dataSize = long.Parse(commandArgs[1]);
                    string dataSet = commandArgs[2];

                    if (dict.ContainsKey(dataSet) == false)
                    {
                        dict[dataSet] = new Dictionary<string, long>();
                    }
                    dict[dataSet][dataKey] = dataSize;
                }
                input = Console.ReadLine();
            }

            {
                var result = dict.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e => e.Value)}");
                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}