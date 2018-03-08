using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var hometown = int.Parse(Console.ReadLine());

            double weekends = 48;
            double normalWeekends = (weekends - hometown) * 3.0 / 4.0;
            double play = holidays * 2.0 / 3.0 + normalWeekends + hometown;

            if (year == "leap")
            {
                play += 0.15 * play;
            }
            Console.WriteLine(Math.Floor(play));
        }
    }
}
