using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var grade = Console.ReadLine();

            var price = 0.0;

            if (type == "room for one person")
            {
                price = (days - 1) * 18;
                if(grade == "positive")
                {
                    price = price + 0.25 * price;
                }
                if(grade == "negative")
                {
                    price = price - 0.10 * price;
                }
            }
            if (type == "apartment")
            {
                price = (days - 1) * 25;
                if (days < 10)
                {
                    price = price - 0.3 * price;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - 0.35 * price;
                }
                else if(days > 15)
                {
                    price = price - 0.50 * price;
                }
                if (grade == "positive")
                {
                    price = price + 0.25 * price;
                }
                if (grade == "negative")
                {
                    price = price - 0.10 * price;
                }
            }
            if (type == "president apartment")
            {
                price = (days - 1) * 35;
                if (days < 10)
                {
                    price = price - 0.10 * price;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - 0.15 * price;
                }
                else if (days > 15)
                {
                    price = price - 0.20 * price;
                }
                if (grade == "positive")
                {
                    price = price + 0.25 * price;
                }
                if (grade == "negative")
                {
                    price = price - 0.10 * price;
                }
            }


            Console.WriteLine("{0:F2}", price);
        }
    }
}
