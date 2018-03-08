using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магически_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegetalbes = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var totalVegetables = int.Parse(Console.ReadLine());
            var totalFruit = int.Parse(Console.ReadLine());

            var vegetables = priceVegetalbes * totalVegetables;
            var fruit = priceFruit * totalFruit;
            var total = vegetables + fruit;
            var totalInEuro = total / 1.94;

            Console.WriteLine("{0}", totalInEuro);
        }
    }
}