using System;

namespace _4.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInHexFormat = Console.ReadLine();

            Console.WriteLine("{0}", Convert.ToInt32(numberInHexFormat,16));
        }
    }
}