using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var word = Console.ReadLine();
            var price = 0.0;
            if(word == "day")
            {
                if (n < 20)
                {
                    price = 0.7 + n * 0.79;
                }
                else if (n >= 20 && n < 100)
                {
                    price = n * 0.09;
                }
                else
                {
                    price = n * 0.06;
                }
            }
            else if(word == "night")
            {
                if (n < 20)
                {
                    price = 0.7 + n * 0.9;
                }
                else if (n >= 20 && n < 100)
                {
                    price = n * 0.09;
                }
                else
                {
                    price = n * 0.06;
                }
            }
            Console.WriteLine("{0:F2}", price);
        }
    }
}
