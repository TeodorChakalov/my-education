using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var volume = length * width * height;
            var litters = volume * 0.001;
            var percent1 = percent * 0.01;
            var realLitters = litters * (1 - percent1);

            Console.WriteLine("{0:F3}", realLitters);
        }
    }
}
