using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lection = double.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var countJelev = 0;
            var countRoyal = 0;
            var countRoli = 0;
            var countTrofon = 0;
            var countSino = 0;
            var countOther = 0;

            for (int i = 1; i <= lection; i++)
            {
                var name = Console.ReadLine();

                if (name == "Jelev") countJelev++;
                else if (name == "RoYaL") countRoyal++;
                else if (name == "Roli") countRoli++;
                else if (name == "Trofon") countTrofon++;
                else if (name == "Sino") countSino++;
                else countOther++;
            }

            var moneyForOneLection = budget / lection;

            Console.WriteLine("Jelev salary: {0:F2} lv",moneyForOneLection * countJelev);
            Console.WriteLine("RoYaL salary: {0:F2} lv",moneyForOneLection * countRoyal);
            Console.WriteLine("Roli salary: {0:F2} lv",moneyForOneLection * countRoli);
            Console.WriteLine("Trofon salary: {0:F2} lv",moneyForOneLection * countTrofon);
            Console.WriteLine("Sino salary: {0:F2} lv",moneyForOneLection * countSino);
            Console.WriteLine("Others salary: {0:F2} lv",moneyForOneLection * countOther);
        }
    }
}
