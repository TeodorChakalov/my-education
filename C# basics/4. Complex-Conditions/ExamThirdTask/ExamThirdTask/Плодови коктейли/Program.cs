using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var size = Console.ReadLine();
            var orderCoctails = int.Parse(Console.ReadLine());

            var price = 0.0;
            var sum = 0.0;

            if(size == "small")
            {
                if (fruit == "Watermelon") price = 2 * 56;
                else if (fruit == "Mango") price = 2 * 36.66;
                else if (fruit == "Pineapple") price = 2 * 42.10;
                else if(fruit == "Raspberry") price = 2 * 20;
            }
            else if (size == "big")
            {
                if (fruit == "Watermelon") price = 5 * 28.70;
                else if (fruit == "Mango") price = 5 * 19.60;
                else if (fruit == "Pineapple") price = 5 * 24.80;
                else if (fruit == "Raspberry") price = 5 * 15.20;
            }

            sum = orderCoctails * price;

            if (sum >= 400 && sum <= 1000)
            {
                sum = sum - 0.15 * sum;
            }
            else if (sum > 1000)
            {
                sum = sum - 0.5 * sum;
            }

            Console.WriteLine("{0:F2} lv.", sum);
        }
    }
}
