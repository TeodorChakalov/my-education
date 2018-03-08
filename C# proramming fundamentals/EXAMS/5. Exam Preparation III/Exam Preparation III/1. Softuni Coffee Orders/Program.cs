using System;
using System.Globalization;

namespace _1.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                long daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var totalPrice = (daysInMonth * capsules) * price;
                Console.WriteLine("The price for the coffee is: ${0:F2}", totalPrice);
                sum += totalPrice;
            }
            Console.WriteLine("Total: ${0:F2}", sum);
        }
    }
}