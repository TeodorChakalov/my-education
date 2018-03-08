using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var a = firstNumber / 1000;
            var b = firstNumber / 100 % 10;
            var c = (firstNumber / 10) % 10;
            var d = firstNumber % 10;

            var a1 = secondNumber / 1000;
            var b1 = secondNumber / 100 % 10;
            var c1 = (secondNumber / 10) % 10;
            var d1 = secondNumber % 10;

            for (int i = a; i <= a1; i++)
            {
                for (int j = b; j <= b1; j++)
                {
                    for (int k = c; k <= c1; k++)
                    {
                        for (int l = d; l <= d1; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
