using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var countStudents = int.Parse(Console.ReadLine());

            var count2To299 = 0.0;
            var count3To399 = 0.0;
            var count4To499 = 0.0;
            var countOver5 = 0.0;
            var sum = 0.0;

            for (int i = 0; i < countStudents; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade <= 2.99)
                {
                    count2To299++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    count3To399++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    count4To499++;
                }
                else if(grade >= 5.00)
                {
                    countOver5++;
                }

                sum += grade;
            }

            var average = sum / countStudents;

            Console.WriteLine("Top students: {0:F2}%", countOver5 / countStudents * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", count4To499 / countStudents * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", count3To399 / countStudents * 100);
            Console.WriteLine("Fail: {0:F2}%", count2To299 / countStudents * 100);
            Console.WriteLine("Average: {0:F2}", average);
        }
    }
}
