using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стипендии
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var averageSuccess = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());

            var socialScolarship = 0.35 * minSalary;
            var excellentScolarship = averageSuccess * 25;


            if (averageSuccess >= 5.50)
            {
                if (socialScolarship <= excellentScolarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excellentScolarship));
                }
                else if(socialScolarship >= excellentScolarship && income < minSalary)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Round(socialScolarship)} BGN");
                }

            }
            else if ((income < minSalary && averageSuccess >= 4.50))
            {
                Console.WriteLine($"You get a Social scholarship {Math.Round(socialScolarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}