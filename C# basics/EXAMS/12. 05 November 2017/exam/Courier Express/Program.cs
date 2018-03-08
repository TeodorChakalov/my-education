using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var lenght = int.Parse(Console.ReadLine());

            var price = 0.0;

            if(type == "standard")
            {
                if (weight < 1)
                {
                    price = lenght * 0.03;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    price =lenght * 0.05;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    price =lenght *  0.1;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    price =lenght * 0.15;
                }
                else if (weight >= 91 && weight <= 150)
                {
                    price =lenght * 0.20;
                }
            }
            else if(type == "express")
            {
                if (weight < 1)
                {
                    price = lenght * 0.03 + 0.03 * 0.8 * weight * lenght;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    price = lenght * 0.05 + 0.4 * 0.05 * weight * lenght;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    price = lenght * 0.1 + 0.05 * 0.1 * weight * lenght;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    price = lenght * 0.15 + 0.02 * 0.15 * weight * lenght;
                }
                else if (weight >= 91 && weight <= 150)
                {
                    price = lenght * 0.20 + 0.01 * 0.2 * weight * lenght; 
                }
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:F3} kg. would cost {1:F2} lv.", weight, price);
        }
    }
}
