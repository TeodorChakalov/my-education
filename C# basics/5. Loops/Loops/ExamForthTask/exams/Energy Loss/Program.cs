using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var countTrainDays = double.Parse(Console.ReadLine());
            var dancers = double.Parse(Console.ReadLine());
            var evenDaysEvenHours = 0.0;
            var evenDaysOddHours = 0.0 ;
            var oddDaysEvenHours = 0.0 ;
            var oddDaysOddHours = 0.0 ;

            for (int i = 1; i <= countTrainDays; i++)
            {
                var hours = int.Parse(Console.ReadLine());

                if ((i % 2 == 0) && (hours % 2 == 0))
                {
                    evenDaysEvenHours += 68 * dancers;
                }
                else if((i % 2 == 0) && (hours % 2 != 0))
                {
                    evenDaysOddHours += 65 * dancers;
                }
                else if ((i % 2 != 0) && (hours % 2 == 0))
                {
                    oddDaysEvenHours += 49 * dancers;
                }
                else if ((i % 2 != 0) && (hours % 2 != 0))
                {
                    oddDaysOddHours += 30 * dancers;
                }
            }
            var allEnergy = 100 * countTrainDays * dancers;
            var remainEnergy = allEnergy - (evenDaysEvenHours + evenDaysOddHours + oddDaysEvenHours + oddDaysOddHours);
            var remainEnergyPerDancer = remainEnergy / dancers / countTrainDays;

            if (remainEnergyPerDancer >= 50)
            {
                Console.WriteLine("They feel good! Energy left: {0:F2}", remainEnergyPerDancer);
            }
            else
            {
                Console.WriteLine("They are wasted! Energy left: {0:F2}", remainEnergyPerDancer);
            }
        }
    }
}
