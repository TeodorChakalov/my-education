using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= firstNumber; j++)
                {
                    for (char k = 'a'; k < 'a' + secondNumber; k++)
                    {
                        for(char l = 'a'; l < 'a' + secondNumber; l++)
                        {
                            for (int m = 1; m <= firstNumber; m++)
                            {
                                if(m > i && m > j)
                                Console.Write($"{i}{j}{k}{l}{m} ");
                            }

//for (int m = Math.Max(i, j) + 1; m <= firstNumber; m++)

                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}