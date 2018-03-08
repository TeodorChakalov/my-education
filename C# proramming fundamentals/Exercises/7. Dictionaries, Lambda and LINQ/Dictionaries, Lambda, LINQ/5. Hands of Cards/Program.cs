using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            List<string> cards = new List<string>();
            int sum = 0;

            string[] hand = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (hand[0] != "JOKER")
            {
                string name = hand[0];
                cards = hand[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                cards = cards.Distinct().ToList();

                if (players.ContainsKey(name) == false)
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            int multiplier = 0;
            int mainValue = 0;
            foreach (var pair in players)
            {
                foreach (var card in pair.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S': multiplier = 4; break;
                        case 'H': multiplier = 3; break;
                        case 'D': multiplier = 2; break;
                        case 'C': multiplier = 1; break;
                    }

                    string power = card.Remove(card.Length - 1, 1);
                    switch (power)
                    {
                        case "J": mainValue = 11; break;
                        case "Q": mainValue = 12; break;
                        case "K": mainValue = 13; break;
                        case "A": mainValue = 14; break;
                        default: mainValue = int.Parse(power); break;
                    }
                    sum += multiplier * mainValue;
                }
                Console.WriteLine("{0}: {1}", pair.Key, sum);
                sum = 0;
            }
        }
    }
}