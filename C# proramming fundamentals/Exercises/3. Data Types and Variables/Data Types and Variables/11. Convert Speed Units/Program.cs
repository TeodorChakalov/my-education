using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());


            var totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            float metresPerSeconds = distanceInMeters / totalTimeInSeconds;
            float kilometresPerHours = ((float)distanceInMeters / 1000) / ((float)totalTimeInSeconds / 3600);
            float milesPerHours = ((float)distanceInMeters / 1609) / ((float)totalTimeInSeconds / 3600);

            Console.WriteLine("{0}", metresPerSeconds);
            Console.WriteLine("{0}", kilometresPerHours);
            Console.WriteLine("{0}", milesPerHours);


        }
    }
}