using System;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = Math.Floor(years * 365.2422);
            var hours = (int)days * 24;
            var minutes = hours * 60m;
            var seconds = minutes * 60m;
            var milliseconds = seconds * 1000m;
            var microseconds = milliseconds * 1000m;
            var nanoseconds = microseconds * 1000m;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}