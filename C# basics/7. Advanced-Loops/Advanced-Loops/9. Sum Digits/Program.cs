using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            do
            {
                sum = sum + (num % 10);
                num = num / 10;
            } while (num > 0);

            Console.WriteLine("Sum of digits: {0}",sum);
            /*
            string n = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                char symbol = n[i];
                int parsedNumber = int.Parse(symbol.ToString());
                sum += parsedNumber;
            }
            Console.WriteLine(sum);
            */
        }
    }
}
