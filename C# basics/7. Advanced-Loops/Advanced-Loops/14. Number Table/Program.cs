using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

//int n = int.Parse(Console.ReadLine());

//var currentNum = 1;
//            for (int row = 1; row <= n; row++)
//            {
//                for (int col = row; col <= row + n - 1; col++)
//                {
//                    if(col > n)
//                    {
//                        currentNum = 2 * n - col;
//                        Console.Write("{0} ", currentNum);
//                    }
//                    else
//                    {
//                        Console.Write("{0} ", col);
//                    }
//                }
//                Console.WriteLine();
//            }

//------------------------------------------------------------------------------------------------------

/*
for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write("{0} ", col);
                }
                for (int col = n - 1; col > n - row; col--)
                {
                    Console.Write("{0} ", col);

                }
                Console.WriteLine();
            }
*/
