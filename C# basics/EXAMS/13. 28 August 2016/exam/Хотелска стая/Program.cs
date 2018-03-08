using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var countNights = int.Parse(Console.ReadLine());
            var priceStudio = 0.0;
            var priceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;
                if (countNights > 7 && countNights <= 14)
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                }
                else if (countNights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                    priceApartment = priceApartment - 0.10 * priceApartment;
                }
            }
            else if(month =="June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (countNights > 14)
                {
                    priceStudio = priceStudio - 0.20 * priceStudio;
                    priceApartment = priceApartment - 0.10 * priceApartment;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;
                if (countNights > 14)
                {
                    priceApartment = priceApartment - 0.10 * priceApartment;
                }
            }

            Console.WriteLine("Apartment: {0:F2} lv.", countNights * priceApartment);
            Console.WriteLine("Studio: {0:F2} lv.",countNights * priceStudio);
        }
    }
}
