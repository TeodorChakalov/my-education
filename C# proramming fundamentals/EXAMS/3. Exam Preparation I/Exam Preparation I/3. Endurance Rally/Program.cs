using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            List<int> checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            foreach (string driver in drivers)
            {
                bool outOfFuel = false;
                int reachedIndex = 0;
                double firstLetter = driver[0];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        firstLetter += numbers[i];
                    }
                    else
                    {
                        firstLetter -= numbers[i];
                    }

                    if (firstLetter <= 0)
                    {
                        outOfFuel = true;
                        reachedIndex = i;
                        break;
                    }

                }

                if (outOfFuel == true)
                {
                    Console.WriteLine("{0} - reached {1}",driver, reachedIndex);
                }
                else
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", driver, firstLetter);
                }

            }
        }
    }
}