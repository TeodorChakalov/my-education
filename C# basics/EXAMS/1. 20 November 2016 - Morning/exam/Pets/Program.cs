using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var countDays = int.Parse(Console.ReadLine());
            var remainFood = int.Parse(Console.ReadLine());
            var foodForDog = double.Parse(Console.ReadLine());
            var foodForCat = double.Parse(Console.ReadLine());
            var foodForTurtle = double.Parse(Console.ReadLine());

            var needFoodForDog = countDays * foodForDog;
            var needFoodForCat = countDays * foodForCat;
            var needFoodForTurtle = (countDays * foodForTurtle) / 1000;

            var totalFood = needFoodForDog + needFoodForCat + needFoodForTurtle;

            if (remainFood - totalFood >= 0)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(remainFood - totalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFood - remainFood));
            }
        }
    }
}
