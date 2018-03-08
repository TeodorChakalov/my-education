using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", miles * 1.60934);
        }
    }
}