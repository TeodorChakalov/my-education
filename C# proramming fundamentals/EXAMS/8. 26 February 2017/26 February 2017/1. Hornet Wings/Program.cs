using System;

namespace _1.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000WindFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000) * distancePer1000WindFlaps;

            int secondFlaps = wingFlaps / 100;
            int rests = wingFlaps / endurance * 5;
            int result = secondFlaps + rests;

            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", result);

        }
    }
}