using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split('|');

            while(input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if(dict.ContainsKey(country) == false)
                {
                    Dictionary<string, long> helper = new Dictionary<string, long>();
                    helper.Add(city, population);
                    dict.Add(country, helper);
                }
                else
                {
                    if(dict[country].ContainsKey(city) == false)
                    {
                        dict[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|');
            }

            foreach (var pair in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value.Values.Sum());
                foreach (var city in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}