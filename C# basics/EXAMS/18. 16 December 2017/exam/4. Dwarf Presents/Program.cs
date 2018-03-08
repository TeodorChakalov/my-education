using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            var countDjudje = int.Parse(Console.ReadLine());
            var money = int.Parse(Console.ReadLine());
            var price = 0.0;

            for (int i = 0; i < countDjudje; i++)
            {
                var gift = Console.ReadLine();

                if(gift == "sand clock")
                {
                    price += 2.2;
                }
                if(gift == "magnet")
                {
                    price += 1.5;
                }
                if(gift == "cup")
                {
                    price += 5;
                }
                if(gift == "t-shirt")
                {
                    price += 10;
                }
            }

            if(price <= money)
            {
                Console.WriteLine("Santa Claus has {0:F2} more leva left!", money - price);
            }
            else
            {
                Console.WriteLine("Santa Claus will need {0:F2} more leva.", price - money);
            }
        }
    }
}
