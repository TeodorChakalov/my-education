using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var partisipents = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            var dict = new Dictionary<string, List<string>>();

            bool isAwarded = true;

            string command = Console.ReadLine();
            while (command != "dawn")
            {
                var commandArgs = command.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
                string personName = commandArgs[0];
                string song = commandArgs[1];
                string award = commandArgs[2];

                if (partisipents.Contains(personName) && songs.Contains(song))
                {
                    if (dict.ContainsKey(personName) == false)
                    {
                        dict[personName] = new List<string>();
                    }
                    if (dict[personName].Contains(award))
                    {
                        dict[personName].Remove(award);
                    }
                    dict[personName].Add(award);
                    isAwarded = false;
                }

                command = Console.ReadLine();
            }

            if (isAwarded)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var name in dict.OrderByDescending(x => x.Value.Count))
                {
                    Console.WriteLine("{0}: {1} awards", name.Key, name.Value.Count);
                    foreach (var song in name.Value.OrderBy(a => a))
                    {
                        Console.WriteLine("--{0}", song);
                    }
                }
            }
        }
    }
}
