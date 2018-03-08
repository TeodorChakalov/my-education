using System;

namespace _9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            try
            {
                while (true)
                {
                    var number = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch
            {
                Console.WriteLine("{0}", counter);
            }
        }
    }
}