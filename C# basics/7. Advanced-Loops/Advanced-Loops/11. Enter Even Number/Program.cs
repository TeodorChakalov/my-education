using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var n = 0;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) break;
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine("Even number entered: {0}", n);
            */

            var n = int.Parse(Console.ReadLine());

            while (n % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
