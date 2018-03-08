using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var typeGroup = Console.ReadLine();
            var countStudents = int.Parse(Console.ReadLine());
            var countNights = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (typeGroup == "girls")
            {
                if (season == "Winter")
                {
                    price = countStudents * countNights * 9.6;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Gymnastics {0:F2} lv.", price);
                }
                else if (season == "Spring")
                {
                    price = countStudents * countNights * 7.2;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Athletics {0:F2} lv.", price);
                }
                else if (season == "Summer")
                {
                    price = countStudents * countNights * 15;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Volleyball {0:F2} lv.", price);
                }
            }
            if (typeGroup == "boys")
            {
                if (season == "Winter")
                {
                    price = countStudents * countNights * 9.6;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Judo {0:F2} lv.", price);
                }
                else if (season == "Spring")
                {
                    price = countStudents * countNights * 7.2;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Tennis {0:F2} lv.", price);
                }
                else if (season == "Summer")
                {
                    price = countStudents * countNights * 15;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Football {0:F2} lv.", price);
                }
            }

            if (typeGroup == "mixed")
            {
                if (season == "Winter")
                {
                    price = countStudents * countNights * 10;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Ski {0:F2} lv.", price);
                }
                else if (season == "Spring")
                {
                    price = countStudents * countNights * 9.50;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Cycling {0:F2} lv.", price);
                }
                else if (season == "Summer")
                {
                    price = countStudents * countNights * 20;
                    if (countStudents >= 10 && countStudents < 20)
                    {
                        price = price - 0.05 * price;
                    }
                    else if (countStudents >= 20 && countStudents < 50)
                    {
                        price = price - 0.15 * price;
                    }
                    else if (countStudents >= 50)
                    {
                        price = price - 0.50 * price;
                    }
                    Console.WriteLine("Swimming {0:F2} lv.", price);
                }
            }
        }
    }
}