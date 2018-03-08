using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            var partition = int.Parse(Console.ReadLine());
            var priceForOnePoint = double.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 1; i <= partition; i++)
            {
                var points = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    sum = sum + points * 2;
                }
                else
                {
                    sum += points;
                }
            }

            var price = priceForOnePoint * sum;
            Console.WriteLine("The project prize was {0:F2} lv.", price);

        }
    }
}
