using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surface = Console.ReadLine();
            string mantle = Console.ReadLine();
            string surfaceMantleCore = Console.ReadLine();
            mantle = Console.ReadLine();
            surface = Console.ReadLine();

            string pattern1 = @"(^[^a-zA-Z0-9]+)$";
            string pattern2 = @"(^[0-9_]+)$";
            string pattern3 = @"(^[^a-zA-Z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^a-zA-Z0-9]+)$";

            if (Regex.IsMatch(surface, pattern1) == false)
            {
                Console.WriteLine("Invalid");
                return;
            }
            else if (Regex.IsMatch(mantle, pattern2) == false)
            {
                Console.WriteLine("Invalid");
                return;
            }
            else if (Regex.IsMatch(surfaceMantleCore, pattern3) == false)
            {
                Console.WriteLine("Invalid");
                return;
            }
            else if (Regex.IsMatch(mantle, pattern2) == false)
            {
                Console.WriteLine("Invalid");
                return;
            }
            else if (Regex.IsMatch(surface, pattern1) == false)
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid");

            Match match = Regex.Match(surfaceMantleCore, pattern3);
            int coreLenght = match.Groups[3].Length;

            Console.WriteLine("{0}", coreLenght);

            //-----------------------------------------------------------------------------------------

            //            using System;
            //            using System.Collections.Generic;
            //            using System.Linq;
            //            using System.Text.RegularExpressions;

            //namespace _3.Snowflake
            //    {
            //        class Program
            //        {
            //            static void Main(string[] args)
            //            {
            //                string surface = Console.ReadLine();
            //                string mantle = Console.ReadLine();
            //                string surfaceMantleCore = Console.ReadLine();
            //                mantle = Console.ReadLine();
            //                surface = Console.ReadLine();

            //                string pattern1 = @"(^[^a-zA-Z0-9]+)$";
            //                string pattern2 = @"(^[0-9_]+)$";
            //                string pattern3 = @"(^[^a-zA-Z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^a-zA-Z0-9]+)$";

            //                bool match1 = false;
            //                bool match2 = false;
            //                bool match3 = false;
            //                bool match4 = false;
            //                bool match5 = false;


            //                MatchCollection matches = Regex.Matches(surface, pattern1);
            //                if (Regex.IsMatch(surface, pattern1))
            //                {
            //                    match1 = true;
            //                }

            //                MatchCollection matches1 = Regex.Matches(mantle, pattern2);
            //                if (Regex.IsMatch(mantle, pattern2))
            //                {
            //                    match2 = true;
            //                }

            //                MatchCollection matches2 = Regex.Matches(surfaceMantleCore, pattern3);
            //                var core = 0;

            //                if (Regex.IsMatch(surfaceMantleCore, pattern3))
            //                {
            //                    match3 = true;
            //                }

            //                foreach (Match m in matches2)
            //                {
            //                    core = m.Groups[3].Length;
            //                }

            //                MatchCollection matches3 = Regex.Matches(mantle, pattern2);
            //                if (Regex.IsMatch(mantle, pattern2))
            //                {
            //                    match4 = true;
            //                }

            //                MatchCollection matches4 = Regex.Matches(surface, pattern1);
            //                if (Regex.IsMatch(surface, pattern1))
            //                {
            //                    match5 = true;
            //                }

            //                if (match1 && match2 && match3 && match4 && match5)
            //                {
            //                    Console.WriteLine("Valid");
            //                    Console.WriteLine("{0}", core);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid");
            //                }
            //            }
            //        }
            //    }
        }
    }
}