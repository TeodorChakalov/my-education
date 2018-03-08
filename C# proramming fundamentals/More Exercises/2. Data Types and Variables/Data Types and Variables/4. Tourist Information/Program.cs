using System;

namespace _4.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitsToConvert = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (unitsToConvert)
            {
                case "miles": Console.WriteLine("{0} miles = {1:F2} kilometers", value, value * 1.6); break;
                case "inches": Console.WriteLine("{0} inches = {1:F2} centimeters", value, value * 2.54); break;
                case "feet": Console.WriteLine("{0} feet = {1:F2} centimeters", value, value * 30); break;
                case "yards": Console.WriteLine("{0} yards = {1:F2} meters", value, value * 0.91); break;
                case "gallons": Console.WriteLine("{0} gallons = {1:F2} liters", value, value * 3.8); break;
                    default: break;
            }
        }
    }
}