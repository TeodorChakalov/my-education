using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOldPeople = int.Parse(Console.ReadLine());
            var countStudents = int.Parse(Console.ReadLine());
            var countNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var price = 0.0;

            if(transport == "train")
            {
                price = 2 * (countOldPeople * 24.99 + countStudents * 14.99);
                if (countOldPeople + countStudents >= 50)
                {
                    price = price - 0.5 * price;
                }
            }
            else if(transport == "bus")
            {
                price = 2 * (countOldPeople * 32.50 + countStudents * 28.50);
            }
            else if(transport == "boat")
            {
                price = 2 * (countOldPeople * 42.99 + countStudents * 39.99);
            }
            else if(transport == "airplane")
            {
                price = 2 * (countOldPeople * 70.00 + countStudents * 50.00);
            }

            var hotel = countNights * 82.99;
            var commision = (price + hotel) * 0.10;
            var totalSum = price + hotel + commision;

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
