using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var move = int.Parse(Console.ReadLine());

            var result = 0.0;
            var count0To9 = 0.0;
            var count10To19 = 0.0;
            var count20To29 = 0.0;
            var count30To39 = 0.0;
            var count40To50 = 0.0;
            var countInvalidNumbers = 0.0;

            for (int i = 0; i < move; i++)
            {
                var numbersInInterval = int.Parse(Console.ReadLine());

                if (numbersInInterval >= 0 && numbersInInterval <= 9)
                {
                    result += 0.2 * numbersInInterval;
                    count0To9++;
                }
                else if (numbersInInterval >= 10 && numbersInInterval <= 19)
                {
                    result += 0.3 * numbersInInterval;
                    count10To19++;
                }
                else if (numbersInInterval >= 20 && numbersInInterval <= 29)
                {
                    result += 0.4 * numbersInInterval;
                    count20To29++;
                }
                else if (numbersInInterval >= 30 && numbersInInterval <= 39)
                {
                    result += 50;
                    count30To39++;
                }
                else if (numbersInInterval >= 40 && numbersInInterval <= 50)
                {
                    result += 100;
                    count40To50++;
                }
                else
                {
                    result /=2;
                    countInvalidNumbers++;
                }
            }

            Console.WriteLine("{0:F2}", result);
            Console.WriteLine("From 0 to 9: {0:F2}%", count0To9 / move * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", count10To19 / move * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", count20To29 / move * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", count30To39 / move * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", count40To50 / move * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", countInvalidNumbers / move * 100);
        }
    }
}
