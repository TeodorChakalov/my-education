using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = secondNumber; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    counter++;
                    if(sum >= controlNumber)
                    {
                        Console.WriteLine("{0} moves", counter);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
                        return;
                    }
                }
            }
            if (sum < controlNumber)
            {
                Console.WriteLine("{0} moves", counter);
            }
        }
    }
}