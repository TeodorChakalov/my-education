using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ame_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var moves = int.Parse(Console.ReadLine());
            var num0To9 = 0.0;
            var num10To19 = 0.0;
            var num20To29 = 0.0;
            var num30To39 = 0.0;
            var num40To50 = 0.0;
            var invalidNumber = 0.0;
            var sum = 0.0;

            for (int i = 0; i < moves; i++)
            {
                var numbers = int.Parse(Console.ReadLine());

                if (numbers >= 0 && numbers <= 9)
                {
                    sum = sum + 0.2 * numbers;
                    num0To9++;
                }
                else if(numbers >= 10 && numbers <= 19)
                {
                    sum = sum + 0.3 * numbers;
                    num10To19++;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    sum = sum + 0.4 * numbers;
                    num20To29++;
                }
                else if (numbers >= 30 && numbers <= 39)
                {
                    sum = sum + 50;
                    num30To39++;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    sum = sum + 100;
                    num40To50++;
                }
                else
                {
                    sum = sum / 2;
                    invalidNumber++;
                }
            }

            Console.WriteLine("{0:F2}",sum);
            Console.WriteLine("From 0 to 9: {0:F2}%", num0To9 / moves * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", num10To19 / moves * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", num20To29 / moves * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", num30To39 / moves * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", num40To50 / moves * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", invalidNumber / moves * 100);
        }
    }
}
