using System;

namespace _5.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string n = number.ToString();

            if (n.Contains("."))
            {
                Console.WriteLine("Rainy");
            }
            else if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}