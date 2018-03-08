using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = firstNumber; i >= secondNumber; i--)
            {
                for (int j = firstNumber; j >= secondNumber; j--)
                {
                    counter++;
                    if(i + j == magicNumber)
                    {
                        Console.Write("Combination N:{0} ",counter);
                        Console.WriteLine("({0} + {1} = {2})",i,j,magicNumber);
                        return;
                    }
                    if (i == secondNumber && j == secondNumber)
                    {
                        Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
                    }
                }
            }
        }
    }
}
