using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _1.Convert_base10_to_baseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int bases = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder sb = new StringBuilder();

            while (number > 0)
            {
                sb.Append(number % bases);
                number /= bases;
            }

            var result = sb.ToString().Reverse().ToArray();
            Console.WriteLine(result);
        }        
    }
}