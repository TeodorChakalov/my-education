using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //Console.Write(new string(' ', n));
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }

            Console.WriteLine(new string('=', 3 * n + 5));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                if(i == (n / 2 - 1))
                {
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                }
                else
                {
                    Console.Write(new string('~', 2 * n + 4));
                }
                Console.Write("|");
                Console.Write(new string(' ', n - 1));
                Console.WriteLine("|");
            }

            Console.WriteLine(new string('=', 3 * n + 5));

            var numberOfa = 2 * n + 4;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("\\");
                Console.Write(new string('@', numberOfa));
                Console.WriteLine("/");

                numberOfa= numberOfa - 2;
            }

            Console.WriteLine(new string('=', 2 * n + 6));
        }
    }
}
