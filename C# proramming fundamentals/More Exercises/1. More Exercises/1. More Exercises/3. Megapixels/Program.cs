using System;

namespace _3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var result = Math.Round(width * height / 1000000 , 1);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, result);
        }
    }
}