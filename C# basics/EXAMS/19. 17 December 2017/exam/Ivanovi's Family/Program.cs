using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var priceForFirstChild = double.Parse(Console.ReadLine());
            var priceForSecondChild = double.Parse(Console.ReadLine());
            var priceForThirdChild = double.Parse(Console.ReadLine());

            var totalSum = priceForFirstChild + priceForSecondChild + priceForThirdChild;
            var budgetWithTaxes = (budget - totalSum) - 0.1 * (budget - totalSum);

            Console.WriteLine("{0:F2}", budgetWithTaxes);
        }
    }
}
