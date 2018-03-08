using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var foodForFirstElen = double.Parse(Console.ReadLine());
            var foodForSecondElen = double.Parse(Console.ReadLine());
            var foodForThirdElen = double.Parse(Console.ReadLine());

            var necessaryFoodForFirstElen = days * foodForFirstElen;
            var necessaryFoodForSecondElen = days * foodForSecondElen;
            var necessaryFoodForThirdElen = days * foodForThirdElen;

            var allFood = necessaryFoodForFirstElen + necessaryFoodForSecondElen + necessaryFoodForThirdElen;

            if(allFood <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - allFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allFood - food));
            }
        }
    }
}
