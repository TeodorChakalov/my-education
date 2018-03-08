using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }

            /*
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i = 2 * i + 1)
            {
                Console.WriteLine(i);
            }
            */
        }
    }
}
