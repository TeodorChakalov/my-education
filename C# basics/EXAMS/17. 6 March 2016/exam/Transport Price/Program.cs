using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometres = int.Parse(Console.ReadLine());
            var word = Console.ReadLine();
            var price = 0.0;

            if (kilometres < 20)
            {
                if(word == "day")
                {
                    price = 0.7 + kilometres * 0.79;
                }
                else if(word == "night")
                {
                    price = 0.7 + kilometres * 0.9;
                }
            }
            else if (kilometres >= 20 && kilometres < 100)
            {
                if (word == "day" || word == "night")
                {
                    price = kilometres * 0.09;
                }
            }
            else if (kilometres >= 100)
            {
                if (word == "day" || word == "night")
                {
                    price = kilometres * 0.06;
                }
            }

            Console.WriteLine("{0}", price);
        }
    }
}
