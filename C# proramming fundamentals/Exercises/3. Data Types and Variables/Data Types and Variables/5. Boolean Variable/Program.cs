using System;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var allText = Convert.ToBoolean(text);
            if(allText)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}