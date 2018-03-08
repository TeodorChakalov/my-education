using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var commision = 0.0;

            if(town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.05 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    commision = 0.07 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    commision = 0.08 * sales;
                }
                else if (sales > 10000)
                {
                    commision = 0.12 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.045 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    commision = 0.075 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    commision = 0.10 * sales;
                }
                else if (sales > 10000)
                {
                    commision = 0.13 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = 0.055 * sales;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    commision = 0.08 * sales;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    commision = 0.12 * sales;
                }
                else if (sales > 10000)
                {
                    commision = 0.145 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("{0:F2}",commision);
        }
    }
}
