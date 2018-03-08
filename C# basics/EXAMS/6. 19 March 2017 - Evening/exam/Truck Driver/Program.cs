using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring")
                {
                    price = 0.75;
                }
                if (season == "Summer")
                {
                    price = 0.90;
                }
                if (season == "Autumn")
                {
                    price = 0.75;
                }
                if (season == "Winter")
                {
                    price = 1.05;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring")
                {
                    price = 0.95;
                }
                if (season == "Summer")
                {
                    price = 1.10;
                }
                if (season == "Autumn")
                {
                    price = 0.95;
                }
                if (season == "Winter")
                {
                    price = 1.25;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                if (season == "Spring" || season == "Summer" || season == "Autumn" || season == "Winter")
                {
                    price = 1.45;
                }
            }

            var salary = kmPerMonth * price * 4;
            var salaryWithoutTax = salary - 0.1 * salary;

            Console.WriteLine("{0:F2}", salaryWithoutTax);
        }
    }
}
