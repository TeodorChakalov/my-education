using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

            string line;
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = line.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string color = tokens[1];
                int physics = int.Parse(tokens[2]);

                string nameColor = $"{name} <:> {color}";

                if (dwarfs.ContainsKey(nameColor) == false)
                {
                    dwarfs.Add(nameColor, physics);

                    if (colors.ContainsKey(color) == false)
                    {
                        colors.Add(color, 1);
                    }
                    else
                    {
                        colors[color]++;
                    }
                }
                else
                {
                    int oldValue = dwarfs[nameColor];
                    if (physics > oldValue)
                    {
                        dwarfs[nameColor] = physics;
                    }
                }
            }

            Dictionary<string, int> sortedDwarfs = dwarfs
                .OrderByDescending(d => d.Value)
                .ThenByDescending(d => colors[d.Key.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in sortedDwarfs)
            {
                string dwarfId = dwarf.Key;
                string[] dwarfIdTokens = dwarfId.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = dwarfIdTokens[0];
                string color = dwarfIdTokens[1];

                int dwarfPhsyics = dwarf.Value;

                Console.WriteLine($"({color}) {name} <-> {dwarfPhsyics}");
            }

            //--------------------------------------------------------------------------------------------------

            //static void Main(string[] args)
            //{
            //    Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            //    string command = Console.ReadLine();

            //    while (command != "Once upon a time")
            //    {
            //        string[] text = command.Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //        string dwarfName = text[0];
            //        string dwarfHatColor = text[1];
            //        int dwarfPhysics = int.Parse(text[2]);

            //        if (dict.ContainsKey(dwarfHatColor) == false)
            //        {
            //            Dictionary<string, int> helper = new Dictionary<string, int>();
            //            helper.Add(dwarfName, dwarfPhysics);
            //            dict.Add(dwarfHatColor, helper);
            //        }
            //        else if (dict[dwarfHatColor].ContainsKey(dwarfName) == false)
            //        {
            //            dict[dwarfHatColor].Add(dwarfName, dwarfPhysics);
            //        }
            //        if (dict[dwarfHatColor][dwarfName] < dwarfPhysics)
            //        {
            //            dict[dwarfHatColor][dwarfName] = dwarfPhysics;
            //        }

            //        command = Console.ReadLine();
            //    }

            //    foreach (var pair in dict.OrderByDescending(x => x.Value.Values.Sum()))
            //    {
            //        foreach (var item in pair.Value)
            //        {
            //            Console.WriteLine("({0}) {1} <-> {2}", pair.Key, item.Key, item.Value);
            //        }
            //    }
            //}

            //------------------------------------------------------------------------------------------------------------

            //Dictionary<string, Dictionary<string, int>> dwarfsByHats = new Dictionary<string, Dictionary<string, int>>();
            //string input = Console.ReadLine();
            //while (input != "Once upon a time")
            //{
            //    string[] token = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
            //    string dwarfName = token[0];
            //    string dwarfHatColor = token[1];
            //    int dwarfPhysics = int.Parse(token[2]);
            //    if (dwarfsByHats.ContainsKey(dwarfHatColor))
            //    {
            //        if (dwarfsByHats[dwarfHatColor].ContainsKey(dwarfName))
            //        {
            //            if (dwarfPhysics > dwarfsByHats[dwarfHatColor][dwarfName])
            //            {
            //                dwarfsByHats[dwarfHatColor][dwarfName] = dwarfPhysics;
            //            }
            //        }
            //        else
            //        {
            //            dwarfsByHats[dwarfHatColor].Add(dwarfName, dwarfPhysics);
            //        }
            //    }
            //    else
            //    {
            //        dwarfsByHats.Add(dwarfHatColor, new Dictionary<string, int>());
            //        dwarfsByHats[dwarfHatColor].Add(dwarfName, dwarfPhysics);
            //    }
            //    input = Console.ReadLine();
            //}
            //Dictionary<string, int> sortedDwarfsByCount = new Dictionary<string, int>();
            //foreach (var dwarfHat in dwarfsByHats.OrderByDescending(x => dwarfsByHats[x.Key].Values.Count))
            //{
            //    foreach (var dwarf in dwarfHat.Value)
            //    {
            //        sortedDwarfsByCount.Add(dwarfHat.Key + " " + dwarf.Key, dwarf.Value);
            //    }
            //}
            //foreach (var dwarf in sortedDwarfsByCount.OrderByDescending(x => x.Value))
            //{
            //    string[] tokenDwarf = dwarf.Key.Split();
            //    Console.WriteLine("({0}) {1} <-> {2}", tokenDwarf[0], tokenDwarf[1], dwarf.Value);
            //}

            //-----------------------------------------------------------------------------------------------------------

            //Dictionary<KeyValuePair<string, string>, long> dwarfs = new Dictionary<KeyValuePair<string, string>, long>();
            //Dictionary<string, int> colors = new Dictionary<string, int>();

            //string line;
            //while ((line = Console.ReadLine()) != "Once upon a time")
            //{
            //    string[] tokens = line.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

            //    string dwarfName = tokens[0];
            //    string dwarfHatColor = tokens[1];
            //    long dwarfPhysics = long.Parse(tokens[2]);

            //    KeyValuePair<string, string> dwarf = new KeyValuePair<string, string>(dwarfName, dwarfHatColor);

            //    if (!dwarfs.ContainsKey(dwarf))
            //    {
            //        dwarfs.Add(dwarf, dwarfPhysics);
            //        if (!colors.ContainsKey(dwarfHatColor))
            //            colors.Add(dwarfHatColor, 0);

            //        colors[dwarfHatColor]++;
            //    }
            //    else
            //    {
            //        if (dwarfPhysics > dwarfs[dwarf])
            //            dwarfs[dwarf] = dwarfPhysics;
            //    }
            //}

            //Dictionary<KeyValuePair<string, string>, long> sorted = dwarfs.OrderByDescending(d => d.Value)
            //    .ThenByDescending(d => colors[d.Key.Value])
            //    .ToDictionary(x => x.Key, x => x.Value);

            //foreach (var dwarf in sorted)
            //{
            //    string hatColor = dwarf.Key.Value;
            //    string name = dwarf.Key.Key;
            //    long physics = dwarf.Value;

            //    Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            //}
        }
    }
}