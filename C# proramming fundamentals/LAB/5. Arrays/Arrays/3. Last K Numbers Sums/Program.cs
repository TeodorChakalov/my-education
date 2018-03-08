using System;

namespace _3.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];

            array[0] = 1;
        
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += array[j];
                    counter++;
                    if(counter > k)
                    {
                        break;
                    }
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}