using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _7.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {

            //BigInteger first = BigInteger.Parse(Console.ReadLine());
            //BigInteger second = BigInteger.Parse(Console.ReadLine());

            //Console.WriteLine("{0}", first * second);

            string number = Console.ReadLine().TrimStart('0');
            int sumator = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            if(sumator == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int reminder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(number[i].ToString());
                int currentResult = currentDigit * sumator + reminder;

                sb.Append(currentResult % 10);
                reminder = currentResult / 10;
            }

            if(reminder != 0)
            {
                Console.Write(reminder);
            }
            Console.WriteLine(sb.ToString().Reverse().ToArray());
        }
    }
}