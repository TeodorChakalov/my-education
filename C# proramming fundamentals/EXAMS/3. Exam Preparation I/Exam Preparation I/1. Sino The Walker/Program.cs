using System;
using System.Globalization;

namespace _1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine()) % 86400;
            int seconds = int.Parse(Console.ReadLine()) % 86400;

            long sumStep = step * seconds;
            TimeSpan time1 = TimeSpan.FromSeconds(sumStep);


            TimeSpan timeSum = time + time1;

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);
        }
    }
}