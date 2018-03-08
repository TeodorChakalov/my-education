using System;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            switch (n)
            {
                case 1: Console.WriteLine(days[0]); break;
                case 2: Console.WriteLine(days[1]); break;
                case 3: Console.WriteLine(days[2]); break;
                case 4: Console.WriteLine(days[3]); break;
                case 5: Console.WriteLine(days[4]); break;
                case 6: Console.WriteLine(days[5]); break;
                case 7: Console.WriteLine(days[6]); break;
                default: Console.WriteLine("Invalid Day!"); break;
            }

            //int dayNum = int.Parse(Console.ReadLine());

            //if(dayNum >=1 && dayNum <= 7)
            //{
            //    Console.WriteLine(days[dayNum - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Day!");
            //}
        }
    }
}