using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var chinaIoana = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            var bitcoinToLv = bitcoins * 1168;
            var chinaIoanToDollars = chinaIoana * 0.15;
            var DollarsToLv = chinaIoanToDollars * 1.76;
            var totalLv = bitcoinToLv + DollarsToLv;
            var totalEuro = totalLv / 1.95;
            var commisions1 = commision / 100 * totalEuro;
            var result = totalEuro - commisions1;

            Console.WriteLine("{0:F2}", result);

        }
    }
}
