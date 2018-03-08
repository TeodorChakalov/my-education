using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var countEmployees = int.Parse(Console.ReadLine());

            var workingHours1 = days - 0.1 * days;
            var workingHours = workingHours1 * 8;
            var employee = countEmployees * (2 * days);
            var totalHours = Math.Floor(workingHours + employee);

            if (totalHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours - totalHours);
            }
        }
    }
}
