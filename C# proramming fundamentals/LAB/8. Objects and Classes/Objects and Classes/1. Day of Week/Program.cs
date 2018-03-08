using System;
using System.Globalization;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            var dateTime = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            var result = dateTime.DayOfWeek;

            Console.WriteLine(result);
        }
    }
}