using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = int.Parse(Console.ReadLine());

            //var intToHex = integer.ToString("X");
            //var intToBinary = Convert.ToString(integer, 2);

            var intToHex = Convert.ToString(integer, 16).ToUpper();
            var intToBinary = Convert.ToString(integer, 2);

            Console.WriteLine("{0}", intToHex);
            Console.WriteLine("{0}", intToBinary);
        }
    }
}