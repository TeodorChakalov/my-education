using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    counter++;
                    if(i + j == magicNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", j, i, magicNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}