using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceLoundry = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());

            var price = 0.0;
            var countToys = 0.0;
            var countPrice = 0.0;
            var sum = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 10;
                    price += sum;
                    countPrice++;
                }
                else
                {
                    countToys++;
                }
            }

            var remainMoney = price;
            var saleToys = countToys * priceToy;
            var brotherTakeMoney = countPrice * 1.00;
            var remainMoneyAfterSales = (remainMoney + saleToys - brotherTakeMoney);

            if(remainMoneyAfterSales >= priceLoundry)
            {
                Console.WriteLine("Yes! {0:F2}", remainMoneyAfterSales - priceLoundry);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", priceLoundry - remainMoneyAfterSales);
            }
        }
    }
}
