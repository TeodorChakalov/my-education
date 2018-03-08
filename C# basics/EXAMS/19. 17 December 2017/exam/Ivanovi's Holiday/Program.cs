using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var countNights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var transport = Console.ReadLine();

            var price = 0.0;

            if(destination == "Miami")
            {
                if (countNights >= 1 && countNights <= 10) price = countNights * (2 * 24.99 + 3 * 14.99) * 1.25;
                else if (countNights >= 11 && countNights <= 15) price = countNights * (2 * 22.99 + 3 * 11.99) * 1.25;
                else if (countNights > 15) price = countNights * (2 * 20 + 3 * 10) * 1.25;
            }
            if (destination == "Canary Islands")
            {
                if (countNights >= 1 && countNights <= 10) price = countNights * (2 * 32.50 + 3 * 28.50) * 1.25;
                else if (countNights >= 11 && countNights <= 15) price = countNights * (2 * 30.50 + 3 * 25.60) * 1.25;
                else if (countNights > 15) price = countNights * (2 * 28 + 3 * 22) * 1.25;
            }
            if (destination == "Philippines")
            {
                if (countNights >= 1 && countNights <= 10) price = countNights * (2 * 42.99 + 3 * 39.99) * 1.25;
                else if (countNights >= 11 && countNights <= 15) price = countNights * (2 * 41 + 3 * 36) * 1.25;
                else if (countNights > 15) price = countNights * (2 * 38.50 + 3 * 32.40) * 1.25;
            }

            if(transport == "train")
            {
                price += 2 * 22.30 + 3 * 12.50;
            }
            if (transport == "bus")
            {
                price += 2 * 45 + 3 * 37;
            }
            if (transport == "airplane")
            {
                price += 2 * 90 + 3 * 68.50;
            }

            Console.WriteLine("{0:F3}", price);
        }
    }
}
