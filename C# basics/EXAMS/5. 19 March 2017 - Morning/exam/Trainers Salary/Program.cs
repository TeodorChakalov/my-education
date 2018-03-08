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
            var lection = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var jelev = 0.0;
            var royal = 0.0;
            var roli = 0.0;
            var trofon = 0.0;
            var sino = 0.0;
            var others = 0.0;

            for (int i = 0; i < lection; i++)
            {
                var lectorName = Console.ReadLine();

                if(lectorName == "Jelev")
                {
                    jelev++;
                }
                else if (lectorName == "RoYaL")
                {
                    royal++;
                }
                else if (lectorName == "Roli")
                {
                    roli++;
                }
                else if (lectorName == "Trofon")
                {
                    trofon++;
                }
                else if (lectorName == "Sino")
                {
                    sino++;
                }
                else
                {
                    others++;
                }
            }

            var moneyForLection = budget / lection;

            Console.WriteLine("Jelev salary: {0:F2} lv", moneyForLection * jelev);
            Console.WriteLine("RoYaL salary: {0:F2} lv", moneyForLection * royal);
            Console.WriteLine("Roli salary: {0:F2} lv", moneyForLection * roli);
            Console.WriteLine("Trofon salary: {0:F2} lv", moneyForLection * trofon);
            Console.WriteLine("Sino salary: {0:F2} lv", moneyForLection * sino);
            Console.WriteLine("Others salary: {0:F2} lv", moneyForLection * others);
        }
    }
}
