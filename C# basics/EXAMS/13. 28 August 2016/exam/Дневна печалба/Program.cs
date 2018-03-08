using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var dollars = double.Parse(Console.ReadLine());

            var oneMonthSalary = workingDays * money;
            var yearIncome = oneMonthSalary * 12 + oneMonthSalary * 2.5;
            var danak = 0.25 * yearIncome;
            var clearIncomeInDollars = yearIncome - danak;
            var clearIncomeInLv = clearIncomeInDollars * dollars;
            var average = clearIncomeInLv / 365;

            Console.WriteLine("{0:F2}", average);
        }

    }
}
