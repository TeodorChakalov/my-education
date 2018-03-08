using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            var spaces = n - stars;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < stars; col++)
                {
                    Console.Write("* ");
                }
                spaces--;
                stars++;
                Console.WriteLine();
            }

            spaces = 1;
            stars = n - spaces;

            for (int row = n; row < 2 * n; row++)
            {
                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < stars; col++)
            {
                Console.Write("* ");
            }
            spaces++;
            stars--;
            Console.WriteLine();
            }

            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= n - row; col++)
            //    {
            //        Console.Write(" ");
            //    }

            //    Console.Write("*");
            //    for (int col = 1; col < row; col++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = n - 1; row >= 1; row--)
            //{
            //    for (int col = 1; col <= n - row; col++)
            //    {
            //        Console.Write(" ");
            //    }

            //    Console.Write("*");
            //    for (int col = 1; col < row; col++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
