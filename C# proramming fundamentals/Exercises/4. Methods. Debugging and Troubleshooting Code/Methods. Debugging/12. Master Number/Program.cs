using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (ContainsEvenDigit(i) && SumOfDigits(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool ContainsEvenDigit(int number)
        {

            while (number > 0)
            {

                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        static bool SumOfDigits(int number)
        {
            var sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberToString = number.ToString();

            for (int i = 0; i < numberToString.Length; i++)
            {
                if (numberToString[i] != numberToString[numberToString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

//int sumElements = 0;

//while (number > 0)
//{
//    int lastDigit = number % 10;
//    sumElements += sumElements * 10 + lastDigit;
//    number /= 10;
//}

//if(sumElements == number)
//{
//    return true;
//}

//return false;

//----------------------------------------------------------------------

//static bool IsPalindrome(int i)
//{
//    int reverse = 0;
//    int notReversedNumber = i;
//    int power = i.ToString().Length - 1;

//    for (int number = 0; number < notReversedNumber.ToString().Length; number++)
//    {
//        reverse += i % 10 * (int)Math.Pow(10, power);
//        power--;
//        i /= 10;
//    }
//    if (notReversedNumber == reverse)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}