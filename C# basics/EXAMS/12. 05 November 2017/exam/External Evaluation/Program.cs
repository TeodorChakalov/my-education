using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countStudents = int.Parse(Console.ReadLine());
            var count1 = 0.0;
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;
            var count5 = 0.0;

            for (int i = 0; i < countStudents; i++)
            {
                var points = double.Parse(Console.ReadLine());

                if (points >= 0 && points <= 22.5)
                {
                    count1++;
                }
                else if (points > 22.5 && points <= 40.5)
                {
                    count2++;
                }
                else if (points > 40.5 && points <= 58.5)
                {
                    count3++;
                }
                else if (points > 58.5 && points <= 76.5)
                {
                    count4++;
                }
                else if (points > 76.5 && points <= 100)
                {
                    count5++;
                }
            }
            Console.WriteLine("{0:F2}% poor marks", count1 / countStudents * 100);
            Console.WriteLine("{0:F2}% satisfactory marks", count2 / countStudents * 100);
            Console.WriteLine("{0:F2}% good marks", count3 / countStudents * 100);
            Console.WriteLine("{0:F2}% very good marks", count4 / countStudents * 100);
            Console.WriteLine("{0:F2}% excellent marks", count5 / countStudents * 100);
        }
    }
}
