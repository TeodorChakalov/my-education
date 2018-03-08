using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var notPrintedLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i != notPrintedLetter && j !=notPrintedLetter && k != notPrintedLetter)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }                      
                    }
                }
            }
        }
    }
}