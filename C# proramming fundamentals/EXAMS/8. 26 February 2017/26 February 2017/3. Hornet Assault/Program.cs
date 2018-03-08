using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornet = Console.ReadLine().Split().Select(long.Parse).ToList();

            long Power = hornet.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornet.Count == 0)
                {
                    break;
                }
                if (Power > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= Power;
                    hornet.RemoveAt(0);
                    Power = hornet.Sum();
                }

            }

            if (beehives.All(x => x == 0))
            {
                Console.WriteLine(string.Join(" ", hornet));
            }
            else
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x != 0).ToList()));
            }
        }
    }
}