using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation___по_стар_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOldPeople = int.Parse(Console.ReadLine());
            var countStudents = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var price = 0.0;

            if(transport == "train")
            {
                price = (countOldPeople * 24.99 + countStudents * 14.99) * 2;
                if (countStudents + countOldPeople >= 50)
                {
                    price = price - 0.5 * price;
                }
            }
            else if(transport == "bus")
            {
                price = (countOldPeople * 32.50 + countStudents * 28.50) * 2;
            }
            else if (transport == "boat")
            {
                price = (countOldPeople * 42.99 + countStudents * 39.99) * 2;
            }
            else if (transport == "airplane")
            {
                price = (countOldPeople * 70.00 + countStudents * 50.00) * 2;
            }

            var hotel = nights * 82.99;
            var commision = (price + hotel) * 0.10;
            var sum = price + hotel + commision;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
