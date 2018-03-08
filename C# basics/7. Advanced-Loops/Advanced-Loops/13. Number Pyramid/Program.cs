using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (num <= n)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

//int n = int.Parse(Console.ReadLine());

//int currentNumber = 1;
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("{0} ",currentNumber);
//                    currentNumber++;
//                    if(currentNumber > n)
//                    {
//                        Console.WriteLine();
//                        return;
//                    }
//                }
//                Console.WriteLine();
//            }
//-------------------------------------------------------------------------------------------
/*
    int n = int.Parse(Console.ReadLine());
int num = 1;

            for (int row = 1; ; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", num);

                    if (num == n)
                    {
                        return;
                    }
                    num++;
                }
                Console.WriteLine();
    */