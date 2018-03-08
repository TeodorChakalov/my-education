using System;

namespace _5.Temperature_Conversion
{
    class Program
    {

        static double convertFarenhaitToCelsius(double number)
        {
            return (number - 32) * 5 / 9;
            
        }

        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var celsius = convertFarenhaitToCelsius(number);
            Console.WriteLine("{0:F2}",celsius);
        }
    }
}