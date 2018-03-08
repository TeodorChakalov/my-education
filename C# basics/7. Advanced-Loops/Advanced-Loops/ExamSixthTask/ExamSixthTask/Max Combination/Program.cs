using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var maxCountCombination = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    counter++;
                    if (counter <= maxCountCombination)
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
