using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftSum = 0.0;
            var rightSum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}",leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}",Math.Abs(leftSum - rightSum));
            }
        }
    }
}
