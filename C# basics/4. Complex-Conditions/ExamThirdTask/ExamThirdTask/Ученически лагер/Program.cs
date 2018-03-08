using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ученически_лагер
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var typeGroup = Console.ReadLine();
            var numberStudents = int.Parse(Console.ReadLine());
            var numberNights = int.Parse(Console.ReadLine());

            var price = 0.0;
            var sports = "";

            if(season == "Winter")
            {
                if (typeGroup == "boys")
                {
                    price = 9.60;
                    sports = "Judo";
                    
                }
                else if (typeGroup == "girls")
                {
                    price = 9.60;
                    sports = "Gymnastics";
                }
                else if (typeGroup == "mixed")
                {
                    price = 10;
                    sports = "Ski";
                }
            }

            else if (season == "Spring")
            {
                if (typeGroup == "boys")
                {
                    price = 7.20;
                    sports = "Tennis";

                }
                else if (typeGroup == "girls")
                {
                    price = 7.20;
                    sports = "Athletics";
                }
                else if (typeGroup == "mixed")
                {
                    price = 9.50;
                    sports = "Cycling";
                }
            }

            else if (season == "Summer")
            {
                if (typeGroup == "boys")
                {
                    price = 15;
                    sports = "Football";

                }
                else if (typeGroup == "girls")
                {
                    price = 15;
                    sports = "Volleyball";
                }
                else if (typeGroup == "mixed")
                {
                    price = 20;
                    sports = "Swimming";
                }
            }

            var priceNight = numberStudents * price * numberNights;

            if (numberStudents >= 10 && numberStudents < 20)
            {
                priceNight = priceNight - 0.05 * priceNight;
            }
            else if (numberStudents >= 20 && numberStudents < 50)
            {
                priceNight = priceNight - 0.15 * priceNight;
            }
            else if (numberStudents >= 50)
            {
                priceNight = priceNight - 0.50 * priceNight;
            }

            Console.WriteLine("{0} {1:F2} lv.",sports, priceNight);
        }
    }
}
