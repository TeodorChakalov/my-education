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
            var countPoorMarks = 0.0;
            var countSatisfactionMarks = 0.0;
            var countGoodMarks = 0.0;
            var countVeryGoodMarks = 0.0;
            var countExcellentMarks = 0.0;

            for (int i = 0; i < countStudents; i++)
            {
                var points = double.Parse(Console.ReadLine());

                if (points >= 0 && points <= 22.5) countPoorMarks++;
                else if (points > 22.5 && points <= 40.5) countSatisfactionMarks++;
                else if (points > 40.5 && points <= 58.5) countGoodMarks++;
                else if (points > 58.5 && points <= 76.5) countVeryGoodMarks++;
                else if (points > 76.5 && points <= 100) countExcellentMarks++;
            }

            Console.WriteLine("{0:F2}% poor marks", countPoorMarks / countStudents * 100);
            Console.WriteLine("{0:F2}% satisfactory marks", countSatisfactionMarks / countStudents * 100);
            Console.WriteLine("{0:F2}% good marks", countGoodMarks / countStudents * 100);
            Console.WriteLine("{0:F2}% very good marks", countVeryGoodMarks / countStudents * 100);
            Console.WriteLine("{0:F2}% excellent marks", countExcellentMarks / countStudents * 100);

        }
    }
}
