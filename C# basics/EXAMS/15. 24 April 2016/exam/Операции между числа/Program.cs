using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();
            var result = 0.0;

            if(symbol == "+")
            {
                result = firstNumber + secondNumber;
                if (result % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even", firstNumber, secondNumber, result);
                else Console.WriteLine("{0} + {1} = {2} - odd", firstNumber, secondNumber, result);
            }
            else if(symbol == "-")
            {
                result = firstNumber - secondNumber;
                if (result % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", firstNumber, secondNumber, result);
                else Console.WriteLine("{0} - {1} = {2} - odd", firstNumber, secondNumber, result);
            }
            else if (symbol == "*")
            {
                result = firstNumber * secondNumber;
                if (result % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even", firstNumber, secondNumber, result);
                else Console.WriteLine("{0} * {1} = {2} - odd", firstNumber, secondNumber, result);
            }
            else if (symbol == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("{0} / {1} = {2:F2}", firstNumber, secondNumber, result);
                }
            }
            else if (symbol == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }
                else
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, result);
                }
            }
        }
    }
}
