using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Bomb_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int counter = 1;
            int arrayInBiggestSequnce = 0;
            int max = 0;

            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (counter > max)
                    {
                        max = counter;
                        arrayInBiggestSequnce = array[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            if (counter == 1)
            {
                Console.WriteLine(array[0]);
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0} ", arrayInBiggestSequnce);
            }
        }
    }
}