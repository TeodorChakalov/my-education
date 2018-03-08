using System;

namespace _6.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i,j,k);
                    }
                }
            }
        }
    }
}