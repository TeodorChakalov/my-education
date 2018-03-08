using System;

namespace _1.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int countOfTargets = 0;
            int halfPower = pokePower / 2;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                countOfTargets++;

                if(pokePower == halfPower && distance > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countOfTargets);
        }
    }
}