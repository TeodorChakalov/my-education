using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = double.Parse(Console.ReadLine());
            var bonusPoints = 0.0;

            if (points <= 100)
            {
                bonusPoints += 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints += 0.2 * points;
            }
            else if(points > 1000)
            {
                bonusPoints += 0.1 * points;
            }

            if(points % 2 == 0)
            {
                bonusPoints += 1;
            }
            if(points % 10 == 5)
            {
                bonusPoints += 2;
            }

            var allPoints = points + bonusPoints;
            Console.WriteLine("{0}", bonusPoints);
            Console.WriteLine("{0}", allPoints);
        }
    }
}