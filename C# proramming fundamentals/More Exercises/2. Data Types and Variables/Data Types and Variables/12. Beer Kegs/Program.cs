using System;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double max = double.MinValue;
            string size = "";

            for (int i = 0; i < 3 * number; i+=3)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * Math.Pow(radius, 2) * height;
                if(volumeKeg > max)
                {
                    max = volumeKeg;
                    size = model;
                }
            }
            Console.WriteLine("{0}", size);
        }
    }
}