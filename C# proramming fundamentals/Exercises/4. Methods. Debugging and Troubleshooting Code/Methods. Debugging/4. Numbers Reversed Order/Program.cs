using System;

namespace _4.Numbers_Reversed_Order
{
    class Program
    {
        static string getReverseText(string text)
        {
            var result = "";
            for (var i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var result = getReverseText(text);
            Console.WriteLine(result);
        }
    }
}