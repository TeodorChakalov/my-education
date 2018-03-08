using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int m = 1; m <= 9; m++)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (number % i == 0 && number % j == 0 && number % m == 0 && number % k == 0)
                            {
                                Console.Write($"{i}{j}{m}{k} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

