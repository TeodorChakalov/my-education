using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            Boolean isValid = (number >= 100 && number <= 200 || number == 0);
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}