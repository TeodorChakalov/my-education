using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фото_снимки
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPictures = double.Parse(Console.ReadLine());
            var kindPictures = Console.ReadLine();
            var methodOrder = Console.ReadLine();

            double sum = 0.0;

            if(kindPictures == "9X13")
            {
                sum = countPictures * 0.16;
                if (countPictures >= 50)
                {
                    sum = sum - 0.05 * sum;
                }
            }

            else if (kindPictures == "10X15")
            {
                sum = countPictures * 0.16;
                if (countPictures >= 80)
                {
                    sum = sum - 0.03 * sum;
                }
            }

            else if (kindPictures == "13X18")
            {
                sum = countPictures * 0.38;             
                if (countPictures >= 50 && countPictures <= 100)
                {
                    sum = sum - 0.03 * sum;
                }
                if(countPictures > 100)
                {
                    sum = sum - 0.05 * sum;
                }
            }

            else if (kindPictures == "20X30")
            {
                sum = countPictures * 2.90;
                if (countPictures >= 10 && countPictures <= 50)
                {
                    sum = sum - 0.07 * sum;
                }
                if (countPictures > 50)
                {
                    sum = sum - 0.09 * sum;
                }
            }

            if(methodOrder == "online")
            {
                sum = sum - 0.02 * sum;
            }
            Console.WriteLine("{0:F2}BGN", sum);
        }
    }
}
