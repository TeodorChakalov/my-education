using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shadowmournebtained = false;
            bool valanyrObtained = false;
            bool dragonwrathObtained = false;

            Dictionary<string, long> recources = new Dictionary<string, long>();
            recources.Add("shards", 0);
            recources.Add("fragments", 0);
            recources.Add("motes", 0);
            Dictionary<string, long> junk = new Dictionary<string, long>();

            while (shadowmournebtained == false && valanyrObtained == false && dragonwrathObtained == false)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0; i < input.Length; i+=2)
                {
                    long quantity = long.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (recources.ContainsKey(material))
                    {
                        recources[material] += quantity;
                    }
                    else if(junk.ContainsKey(material) == false)
                    {
                        junk.Add(material, quantity);
                    }
                    else
                    {
                        junk[material] += quantity;
                    }

                    if(recources["shards"] >= 250)
                    {
                        shadowmournebtained = true;
                        recources["shards"] -= 250;
                        break;
                    }
                    else if(recources["fragments"] >= 250)
                    {
                        valanyrObtained = true;
                        recources["fragments"] -= 250;
                        break;
                    }
                    else if(recources["motes"] >= 250)
                    {
                        dragonwrathObtained = true;
                        recources["motes"] -= 250;
                        break;
                    }
                }
            }

            if(shadowmournebtained == true)
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if(valanyrObtained == true)
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if(dragonwrathObtained == true)
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var recource in recources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", recource.Key, recource.Value);
            }

            foreach (var junkItems in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", junkItems.Key, junkItems.Value);
            }
        }
    }
}