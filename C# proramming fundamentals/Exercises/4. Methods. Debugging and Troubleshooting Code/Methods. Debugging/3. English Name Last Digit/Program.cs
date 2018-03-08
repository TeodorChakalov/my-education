using System;

namespace _3.English_Name_Last_Digit
{
    class Program
    {
        static long GetEnglishNameFromLastDigit(long lastDigit)
        {
            switch (lastDigit)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                    default: break;
            }
            return 0;
        }

        static long GetLastDigit(long number)
        {
            var lastDigit = number % 10;
            long result = GetEnglishNameFromLastDigit(lastDigit);
            return result;
        }

        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            long result = GetLastDigit(number);
        }
    }
}