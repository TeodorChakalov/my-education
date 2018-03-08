using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            int GCD = 0;
            for (int i = Math.Min(a, b); i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    GCD = i;
                    break;
                }
            }
            Console.WriteLine(GCD);


            //while (b != 0)
            //{
            //    var temp = b;
            //    b = a % b;
            //    a = temp;
            //}
            // ----------------------------------------------
            /*
            while(b != 0)
            {
                int result = a % b;
                a = b;
                b = result;
            }
            Console.WriteLine(a);
            */
        }
    }
}
