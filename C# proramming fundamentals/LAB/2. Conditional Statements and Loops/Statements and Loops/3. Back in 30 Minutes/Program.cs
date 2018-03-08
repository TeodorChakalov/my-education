using System;

namespace _3.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;

            if (minutes > 60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            if (minutes >= 0 && minutes <= 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }
    }
}