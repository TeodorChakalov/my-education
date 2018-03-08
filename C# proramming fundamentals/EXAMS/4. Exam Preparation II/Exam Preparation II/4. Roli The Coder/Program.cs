﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, string> eventsById = new Dictionary<int, string>();
            Dictionary<string, List<string>> organizer = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    List<string> eventInfo = input.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    int ID = int.Parse(eventInfo[0]);
                    string eventName = eventInfo[1];

                    List<string> participants = new List<string>();

                    for (int i = 2; i < eventInfo.Count; i++)
                    {
                        participants.Add(eventInfo[i]);
                    }


                    if (!eventsById.ContainsKey(ID))
                    {
                        eventsById.Add(ID, eventName);
                        organizer.Add(eventName, participants);
                    }

                    else if (eventsById[ID] == eventName)
                    {
                        organizer[eventName].AddRange(participants);
                    }
                }

                input = Console.ReadLine();
            }


            foreach (var events in organizer.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{events.Key} - {events.Value.Distinct().Count()}");
                foreach (string participant in events.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}