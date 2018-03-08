using System;

namespace _5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4, 1);

            var time = numberOfBeats / beatsPerMinute * 60;
            var hours = Math.Floor(time / 60);
            var minutes = Math.Floor(time % 60);

            Console.WriteLine("{0} bars - {1}m {2}s", bars, hours, minutes);
        }
    }
}