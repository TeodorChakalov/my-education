using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мобилен_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            var contract = Console.ReadLine();
            var typeContract = Console.ReadLine();
            var addInternet = Console.ReadLine();
            var countMonth = int.Parse(Console.ReadLine());
            double price = 0.0;

            if(contract == "one")
            {
                if (typeContract == "Small") price = 9.98;
                else if (typeContract == "Middle") price = 18.99;
                else if (typeContract == "Large") price = 25.98;
                else if (typeContract == "ExtraLarge") price = 35.99;
                if(addInternet == "yes")
                {
                    if (price <= 10) price = price + 5.5;
                    else if (price > 10 && price <= 30) price = price + 4.35;
                    else if (price > 30) price = price + 3.85;
                }
            }
            else if(contract == "two")
            {
                if (typeContract == "Small") price = 8.58;
                else if (typeContract == "Middle") price = 17.09;
                else if (typeContract == "Large") price = 23.59;
                else if (typeContract == "ExtraLarge") price = 31.79;
                if (addInternet == "yes")
                {
                    if (price <= 10) price = price + 5.5;
                    else if (price > 10 && price <= 30) price = price + 4.35;
                    else if (price > 30) price = price + 3.85;
                }
                price = price - 3.75 / 100 * price;
            }
            Console.WriteLine("{0:F2} lv.", price * countMonth);
        }
    }
}
