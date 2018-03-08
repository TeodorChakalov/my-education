using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var remainTime = 0;
            var hours = 0;
            var minutes = 0;

            var weekends = days * 127;
            var workingDays = 365 - days;
            var playOnWorkingDays = workingDays * 63;
            var total = weekends + playOnWorkingDays;

            if(30000 >= total)
            {
                remainTime = 30000 - total;
                hours = remainTime / 60;
                minutes = remainTime % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                remainTime = total - 30000;
                hours = remainTime / 60;
                minutes = remainTime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }


            Console.WriteLine();
        }
    }
}
