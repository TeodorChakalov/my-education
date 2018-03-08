using System;

namespace _1.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfTheMarathonInDays = int.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            long lengthTrack = long.Parse(Console.ReadLine());
            int capacityTrack = int.Parse(Console.ReadLine());
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());

            int maximumRunners = lengthOfTheMarathonInDays * capacityTrack;

            long minRunners = Math.Min(numberOfRunners, maximumRunners);

            long totalMetres = minRunners * averageNumberOfLaps * lengthTrack;
            long totalKm = totalMetres / 1000;
            decimal money = totalKm * amountOfMoney;

            Console.WriteLine("Money raised: {0:F2}", money);


        }
    }
}