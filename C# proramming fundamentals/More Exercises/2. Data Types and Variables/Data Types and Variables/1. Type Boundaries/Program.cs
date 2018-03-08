using System;

namespace _1.Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if(text == "int")
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if(text == "uint")
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if (text == "long")
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }
            else if (text == "byte")
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if (text == "sbyte")
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }
        }
    }
}