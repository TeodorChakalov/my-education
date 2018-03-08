using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var countCups = int.Parse(Console.ReadLine());
            var countEmployees = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var hours = countEmployees * workingDays * 8;
            var makeCups = hours / 5;

            if (makeCups < countCups)
            {
                var loses = (countCups - makeCups) * 4.2;
                Console.WriteLine("Losses: {0:F2}",loses);
            }
            else
            {
                var profit = (makeCups - countCups) * 4.2;
                Console.WriteLine("{0:F2} extra money", profit);
            }
        }
    }
}
