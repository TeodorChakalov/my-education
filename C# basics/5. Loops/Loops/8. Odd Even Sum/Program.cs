using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var odd = 0.0;
            var even = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num; 
                }
            }

            if(odd == even)
            {
                Console.WriteLine("Yes Sum = {0}", odd);
            }
            else
            {
                Console.WriteLine("No Diff {0}",Math.Abs(even - odd));
            }
        }
    }
}
