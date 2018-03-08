using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var countGroups = int.Parse(Console.ReadLine());
            var allPeople = 0.0;
            var countGroupTill5 = 0.0;
            var countGroupBetween6And12 = 0.0;
            var countGroupBetween13And25 = 0.0;
            var countGroupBetween26And40 = 0.0;
            var countGroupOver41 = 0.0;

            for (int i = 0; i < countGroups; i++)
            {
                var countPeople = int.Parse(Console.ReadLine());
                allPeople += countPeople;

                if (countPeople <= 5)
                {
                    countGroupTill5+= countPeople;
                }
                else if (countPeople >= 6 && countPeople <= 12)
                {
                    countGroupBetween6And12+= countPeople;
                }
                else if (countPeople >= 13 && countPeople <= 25)
                {
                    countGroupBetween13And25+= countPeople;
                }
                else if (countPeople >= 26 && countPeople <= 40)
                {
                    countGroupBetween26And40+=countPeople;
                }
                else if (countPeople >= 41)
                {
                    countGroupOver41+= countPeople;
                }
            }

            Console.WriteLine("{0:F2}%", countGroupTill5 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countGroupBetween6And12 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countGroupBetween13And25 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countGroupBetween26And40 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countGroupOver41 / allPeople * 100);
        }
    }
}