using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnevna_pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dailyPay = double.Parse(Console.ReadLine());
            var USD = double.Parse(Console.ReadLine());

            var monthlyPay = workingDays * dailyPay;
            var salary = monthlyPay * 12 + monthlyPay * 2.5;
            var totalSalaryInUSD = salary - (salary * 0.25);
            var totalSalaryInLevs = totalSalaryInUSD * USD;
            var dailyIncome = totalSalaryInLevs / 365;

            Console.WriteLine("{0:F2}",dailyIncome);
        }
    }
}
