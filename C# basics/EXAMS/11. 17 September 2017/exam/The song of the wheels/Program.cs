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
            int counter = 0;
            var password = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d && a * b + c * d == n)
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                counter++;
                                if (counter == 4)
                                {
                                    password = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }
            if (counter < 4)
            {
                Console.WriteLine("\nNo!");
            }
            if (counter >= 4)
            {
                Console.WriteLine("Password: {0}", password);
            }
        }
    }
}
