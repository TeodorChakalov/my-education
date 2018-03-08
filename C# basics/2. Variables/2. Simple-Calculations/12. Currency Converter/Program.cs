using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();
            double firstCurrencyValue = 0.0;
            double secondCurrencyValue = 0.0;

            if (firstCurrency == "BGN")
            {
                firstCurrencyValue = 1;
            }
            else if (firstCurrency == "USD")
            {
                firstCurrencyValue = 1.79549;
            }
            else if (firstCurrency == "EUR")
            {
                firstCurrencyValue = 1.95583;
            }
            else if (firstCurrency == "GBP")
            {
                firstCurrencyValue = 2.53405;
            }

            if (secondCurrency == "BGN")
            {
                secondCurrencyValue = 1;
            }
            else if (secondCurrency == "USD")
            {
                secondCurrencyValue = 1.79549;
            }
            else if (secondCurrency == "EUR")
            {
                secondCurrencyValue = 1.95583;
            }
            else if (secondCurrency == "GBP")
            {
                secondCurrencyValue = 2.53405;
            }
            double result = money * (firstCurrencyValue / secondCurrencyValue);
            Console.WriteLine("{0:F2} {1}", result, secondCurrency);

         /* double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToLower();//ToLower -прави текста в малки букви
            var second = Console.ReadLine().ToLower();

            if (first == "usd")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.91801, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.70854, 2));
                }

            }

            if (first == "bgn")
            {
                if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.95583, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num / 2.53405, 2));
                }
            }

            if (first == "eur")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.08930, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
            }
            if (first == "gbp")
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.39462, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405 / 1.79549, 2));//Тука беше разликата.
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
        }
    } */
}
    }
}