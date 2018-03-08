using System;

namespace _5.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            if(country == "USA" || country == "England")
            {
                Console.WriteLine("English");
            }
            else if(country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            //var country = Console.ReadLine();

            //switch (country)
            //{
            //    case "USA":
            //    case "England":
            //        Console.WriteLine("English"); break;

            //    case "Spain":
            //    case "Argentina":
            //    case "Mexico":
            //        Console.WriteLine("Spanish"); break;

            //    default: Console.WriteLine("unknown"); break;
            //}
        }
    }
}