using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            var partsProject = int.Parse(Console.ReadLine());
            var moneyPrizeOnePoint = double.Parse(Console.ReadLine());
            var bonusPoints = 0;
            var points = 0;

            for (int i = 1; i <= partsProject; i++)
            {
                points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    bonusPoints += points * 2;
                }
                else
                {
                    bonusPoints += points;
                }
            }

            var prize = moneyPrizeOnePoint * bonusPoints;

            Console.WriteLine("The project prize was {0:F2} lv.", prize);
        }
    }
}
