using System;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            var priceStudio = 0.0;
            var priceDouble = 0.0;
            var priceSuite = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50 * nightsCount;
                priceDouble = 65 * nightsCount;
                priceSuite = 75 * nightsCount;

                if (month == "October" && nightsCount > 7)
                {
                    priceStudio = priceStudio - 50;
                }
                if (nightsCount > 7)
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60 * nightsCount;
                priceDouble = 72 * nightsCount;
                priceSuite = 82 * nightsCount;

                if (month == "September" && nightsCount > 7)
                {
                    priceStudio = priceStudio - 60;
                }
                if (nightsCount > 14)
                {
                    priceDouble = priceDouble - 0.10 * priceDouble;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68 * nightsCount;
                priceDouble = 77 * nightsCount;
                priceSuite = 89 * nightsCount;

                if (nightsCount > 14)
                {
                    priceSuite = priceSuite - 0.15 * priceSuite;
                }
            }

            Console.WriteLine("Studio: {0:F2} lv.", priceStudio);
            Console.WriteLine("Double: {0:F2} lv.", priceDouble);
            Console.WriteLine("Suite: {0:F2} lv.", priceSuite);
        }
    }
}