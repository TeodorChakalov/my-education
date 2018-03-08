using System;
using System.Linq;

namespace _4.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            bool isFound = false;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                counter++;
                if (array[i] == number)
                {
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No occurrences were found!");
            }


            if (isFound)
            {
                for (int i = 0; i < array.Length - counter; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine(sum);
            }

            // ---------------------------------------------------------------------------------
            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int number = int.Parse(Console.ReadLine());

            //long sum = 0;
            //int lastElement = 0;
            //bool isFound = false;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == number)
            //    {
            //        isFound = true;
            //        lastElement = i;
            //    }
            //}
            //if (!isFound)
            //{
            //    Console.WriteLine("No occurrences were found!");
            //}


            //if (isFound)
            //{
            //    for (int i = 0; i < lastElement; i++)
            //    {
            //        sum += array[i];
            //    }
            //    Console.WriteLine(sum);
        }
    }
}