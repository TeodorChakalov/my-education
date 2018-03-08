using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    counter++;
                    {
                        if (sum >= controlNumber)
                        {
                            Console.WriteLine("{0} moves", counter);
                            Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
                            return;
                        }
                    }

                }
            }
            Console.WriteLine("{0} moves", counter);
        }
    }
}
