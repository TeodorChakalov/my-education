using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPictures = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var wayForOrder = Console.ReadLine();
            var price = 0.0;

            if (type == "9X13")
            {
                price = countPictures * 0.16;
                if (countPictures >= 50)
                {
                    price = price - 0.05 * price;
                }
                if (wayForOrder == "online")
                {
                    price = price - 0.02 * price;
                }
            }
            else if (type == "10X15")
            {

                price = countPictures * 0.16;
                if (countPictures >= 80)
                {
                    price = price - 0.03 * price;
                }
                if (wayForOrder == "online")
                {
                    price = price - 0.02 * price;
                }
            }
            else if (type == "13X18")
            {
                price = countPictures * 0.38;
                if (countPictures >= 50 && countPictures <=100)
                {
                    price = price - 0.03 * price;
                }
                else if(countPictures > 100)
                {
                    price = price - 0.05 * price;
                }
                if (wayForOrder == "online")
                {
                    price = price - 0.02 * price;
                }
            }
            else if (type == "20X30")
            {
                price = countPictures * 2.90;
                if (countPictures >= 10 && countPictures <= 50)
                {
                    price = price - 0.07 * price;
                }
                else if (countPictures > 50)
                {
                    price = price - 0.09 * price;
                }
                if (wayForOrder == "online")
                {
                    price = price - 0.02 * price;
                }
            }
            Console.WriteLine("{0:F2}BGN", price);
        }
    }
}
