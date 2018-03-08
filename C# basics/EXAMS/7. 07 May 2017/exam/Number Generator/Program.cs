using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specificNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        //int number = i * 100 + j * 10 + k;
                        int number = int.Parse($"{i}{j}{k}");
                        if (number % 3 == 0)
                        {
                            specificNumber += 5;
                        }
                        else if (number % 5 == 0)
                        {
                            specificNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specificNumber *= 2;
                        }

                        if (specificNumber >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specificNumber);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No! {0} is the last reached special number.", specificNumber);
        }
    }
}
