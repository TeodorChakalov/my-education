using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine("The greater number is: {0}", firstNum);
            }
            else
            {
                Console.WriteLine("The greater number is: {0}", secondNum);
            }
        }
    }
}
