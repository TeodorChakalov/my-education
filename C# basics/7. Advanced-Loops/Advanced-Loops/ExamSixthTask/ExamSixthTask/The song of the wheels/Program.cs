using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;
            string password = "";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (i < j && k > m && i * j + k * m == n)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, m);
                                counter++;

                                if (counter == 4)
                                {
                                    password = $"{i}{j}{k}{m}";
                                }
                            }  
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter < 4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine("Password: {0}", password);
            }
        }
    }
}