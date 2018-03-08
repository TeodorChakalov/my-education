using System;

namespace _3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupCount = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var price = 0.0;
            var allPrice = 0.0;

            if (groupCount <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                price = 2500;
            }
            else if (groupCount > 50 && groupCount <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                price = 5000;
            }
            else if (groupCount > 100 && groupCount <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if(package == "Normal")
            {
                allPrice = price + 500;
                allPrice = allPrice - 0.05 * allPrice;
            }
            else if(package == "Gold")
            {
                allPrice = price + 750;
                allPrice = allPrice - 0.1 * allPrice;
            }
            else if (package == "Platinum")
            {
                allPrice = price + 1000;
                allPrice = allPrice - 0.15 * allPrice;
            }

            Console.WriteLine("The price per person is {0:F2}$", allPrice / groupCount);
        }
    }
}