using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxCountBattles = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    counter++;
                    if(counter <= maxCountBattles)
                    {
                        Console.Write("({0} <-> {1}) ",i, j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
