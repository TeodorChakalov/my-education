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

            var studio = 0.0;
            var apartment = 0.0;

            if(month == "May" || month == "October")
            {
                studio = countNights * 50.00;
                apartment = countNights * 65.00;

                if (countNights > 7 && countNights <= 14)
                {
                    studio = studio - 0.05 * studio;
                }
                else if (countNights > 14)
                {
                    studio = studio - 0.30 * studio;
                    apartment = apartment - 0.1 * apartment;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = countNights * 75.20;
                apartment = countNights * 68.70;

                if (countNights > 14)
                {
                    studio = studio - 0.20 * studio;
                    apartment = apartment - 0.1 * apartment;
                }
            }

            else if (month == "July" || month == "August")
            {
                studio = countNights * 76;
                apartment = countNights * 77;
                if (countNights > 14)
                {
                    apartment = apartment - 0.1 * apartment;
                }
            }

            Console.WriteLine("Apartment: {0:F2} lv.", apartment);
            Console.WriteLine("Studio: {0:F2} lv.", studio);
        }
    }
}
