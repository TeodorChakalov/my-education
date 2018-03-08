using System;
using System.Linq;

namespace _1.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            Console.WriteLine(result);

            //string input = Console.ReadLine();
            //string output2 = new string(input.Reverse().ToArray());
            //Console.WriteLine(output2);
        }
    }
}