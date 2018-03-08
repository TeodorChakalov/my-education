using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var averageSuccess = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());

            var socialScholarship = 0.0;
            var excellentResults = 0.0;

            if (income < minSalary && averageSuccess > 4.5)
            {
                socialScholarship = 0.35 * minSalary;
            }
            if (averageSuccess >= 5.50)
            {
                excellentResults = averageSuccess * 25;
            }

            if (income < minSalary && averageSuccess > 4.5 || averageSuccess >= 5.50)
            {
                if (socialScholarship > excellentResults)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialScholarship));
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excellentResults));
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2_Scholarship
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var cash = double.Parse(Console.ReadLine());
//            var avgsc = double.Parse(Console.ReadLine());
//            var minpay = double.Parse(Console.ReadLine());

//            var flagu = 0;
//            var flags = 0;
//            double stipu = 0.0;
//            double stips = 0.0;

//            if (cash < minpay && avgsc > 4.50) flags = 1;
//            if (avgsc >= 5.50) flagu = 1;

//            if (flagu == 0 && flags == 0) Console.WriteLine("You cannot get a scholarship!");
//            else if (flagu == 1 && flags == 0)
//            {
//                stipu = 25 * avgsc;
//                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(stipu));
//            }
//            else if (flagu == 0 && flags == 1)
//            {
//                stips = minpay * 0.35;
//                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(stips));
//            }
//            else if (flagu == 1 && flags == 1)
//            {
//                stips = minpay * 0.35;
//                stipu = 25 * avgsc;

//                if (stipu > stips) Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(stipu));
//                else Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(stips));
//            }
//        }
//    }
//}
