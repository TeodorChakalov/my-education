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
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            var result = 0.0;

            if (symbol == "+")
            {
                 result = num1 + num2;
                if (result % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even", num1, num2, result);
                else Console.WriteLine("{0} + {1} = {2} - odd", num1, num2, result);
            }
            else if(symbol == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", num1, num2, result);
                else Console.WriteLine("{0} - {1} = {2} - odd", num1, num2, result);
            }
            else if (symbol == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even", num1, num2, result);
                else Console.WriteLine("{0} * {1} = {2} - odd", num1, num2, result);
            }
            if (symbol == "/" && num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2:F2}", num1, num2, result);
            }
            if(symbol == "/" && num2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }
            if (symbol == "%" && num2 !=0)
            {
                result = num1 % num2;
                Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
            }
            if (symbol == "%" && num2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }

        }
    }
}
