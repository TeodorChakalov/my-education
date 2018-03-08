using System;

namespace _2.Max_Method
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                return firstNumber;
            }
            else if(secondNumber>=firstNumber && secondNumber >= thirdNumber)
            {
                return secondNumber;
            }
            else if(thirdNumber>=firstNumber && thirdNumber >= secondNumber)
            {
                return thirdNumber;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var result = GetMax(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }
    }
}