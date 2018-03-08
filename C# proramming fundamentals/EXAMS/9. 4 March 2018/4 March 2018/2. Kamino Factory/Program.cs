using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] array = new int[n];
            List<int> numbers = new List<int>();

            int counter = 0;
            int arrayInBiggestSequnce = 0;
            int max = 0;
            int max1 = 0;
            int bestStartIndex = 0;
            bool flag = false;

            while (input != "Clone them!")
            {
                array = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                counter = 1;
                arrayInBiggestSequnce = 0;
                max = 0;
                bestStartIndex = 0;
                max1 = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        if (array[i] == 1 && array[i + 1] == 1)
                        {
                            counter++;
                            if (counter > max)
                            {
                                max = counter;
                                arrayInBiggestSequnce = array[i];
                                bestStartIndex = array[i];
                                if (bestStartIndex > max1)
                                {
                                    bestStartIndex = i;
                                    flag = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }

                if (max == 1)
                {
                    Console.WriteLine(array[0]);
                }
                flag = false;
                input = Console.ReadLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                var result = Math.Min(bestStartIndex, max1);
                if(flag == true)
                {
                    Console.WriteLine("Best DNA sample {0} with sum: {1}.", );
                }

            }
        }
    }
}