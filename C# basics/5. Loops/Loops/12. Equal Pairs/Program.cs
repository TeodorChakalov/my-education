using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastSum = 0;
            var max = 0;
            var sum = 0;

            for (int i = 1; i <=n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                sum = a + b;

                if(i > 1)
                {
                    int difference = Math.Abs(sum - lastSum);

                    if (difference > max) max = difference;
                }

                lastSum = sum;
            }

            if(max == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", max);
            }
        }
    }
}