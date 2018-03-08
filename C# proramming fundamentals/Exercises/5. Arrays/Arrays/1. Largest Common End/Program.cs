using System;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int lengthLeft = 0;
            int lengthRight = 0;
            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
            {
                if(firstArr[i] == secondArr[i])
                {
                    lengthLeft++;
                }
                if(firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    lengthRight++;
                }
            }
            if(lengthLeft >= lengthRight)
            {
                Console.WriteLine(lengthLeft);
            }
            else
            {
                Console.WriteLine(lengthRight);
            }
        }
    }
}