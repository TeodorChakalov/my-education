using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Pokemon_Evolution
{
    class Evolution
    {
        public string Type { get; set; }
        public int Index { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<Evolution>> dict = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {
                string[] commandArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs.Length == 1)
                {
                    string name = commandArgs[0];

                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine("# {0}", name);
                        foreach (var kvp in dict[name])
                        {
                            Console.WriteLine("{0} <-> {1}", kvp.Type, kvp.Index);
                        }
                    }
                }
                else
                {
                    Evolution evolution = new Evolution();
                    string name = commandArgs[0];
                    evolution.Type = commandArgs[1];
                    evolution.Index = int.Parse(commandArgs[2]);

                    if (dict.ContainsKey(name) == false)
                    {
                        dict[name] = new List<Evolution>();
                    }
                    dict[name].Add(evolution);
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in dict)
            {
                Console.WriteLine("# {0}", pokemon.Key);
                foreach (var kvp in pokemon.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine("{0} <-> {1}", kvp.Type, kvp.Index);
                }

                //string input = Console.ReadLine();
                //Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                //while (input != "wubbalubbadubdub")
                //{
                //    string[] commandArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                //    if (commandArgs.Length == 1)
                //    {
                //        string name = commandArgs[0];

                //        if (dict.ContainsKey(name))
                //        {
                //            Console.WriteLine("# {0}", name);
                //            foreach (var kvp in dict[name])
                //            {
                //                Console.WriteLine("{0}", kvp);
                //            }
                //        }
                //    }
                //    else
                //    {
                //        string name = commandArgs[0];
                //        if (dict.ContainsKey(name) == false)
                //        {
                //            dict[name] = new List<string>();
                //        }

                //        string typeAndIndex = commandArgs[1] + " <-> " + commandArgs[2];
                //        dict[name].Add(typeAndIndex);
                //    }

                //    input = Console.ReadLine();
                //}

                //foreach (var pokemon in dict)
                //{
                //    Console.WriteLine("# {0}", pokemon.Key);
                //    foreach (var kvp in pokemon.Value.OrderByDescending(x => int.Parse(x.Split(new char[] { ' ', '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).First())))
                //    {
                //        Console.WriteLine("{0}", kvp);
                //    }
                //}
            }
        }
    }
}