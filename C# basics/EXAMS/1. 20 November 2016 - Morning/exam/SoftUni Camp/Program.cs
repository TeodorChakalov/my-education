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
            var countGroupStudents = int.Parse(Console.ReadLine());
            var countPeopleTill5 = 0.0;
            var countPeople6To12 = 0.0;
            var countPeople13To25 = 0.0;
            var countPeople26To40 = 0.0;
            var countPeopleOver41 = 0.0;
            var countPeople = 0;
            var allPeople = 0;

            for (int i = 0; i < countGroupStudents; i++)
            {
                countPeople = int.Parse(Console.ReadLine());
                allPeople += countPeople;

                if (countPeople <= 5)
                {
                    countPeopleTill5+=countPeople;
                }
                else if (countPeople >= 6 && countPeople <= 12)
                {
                    countPeople6To12+= countPeople;
                }
                else if (countPeople >= 13 && countPeople <= 25)
                {
                    countPeople13To25+=countPeople;
                }
                else if (countPeople >= 26 && countPeople <= 40)
                {
                    countPeople26To40 += countPeople;
                }
                else if (countPeople >= 41)
                {
                    countPeopleOver41+= countPeople;
                }
            }

            Console.WriteLine("{0:F2}%",countPeopleTill5 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countPeople6To12 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countPeople13To25 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countPeople26To40 / allPeople * 100);
            Console.WriteLine("{0:F2}%", countPeopleOver41 / allPeople * 100);
        }
    }
}
