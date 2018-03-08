using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            var difference = second - first;
            if (difference < 5)
            {
                Console.WriteLine("No");
            }

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        for (int l = first; l <= second; l++)
                        {
                            for (int m = first; m <= second; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.Write("{0} {1} {2} {3} {4}", i, j, k, l, m);
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}