using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigLetter = char.Parse(Console.ReadLine());
            var firstSmallLetter = char.Parse(Console.ReadLine());
            var secondSmallLetter = char.Parse(Console.ReadLine());
            var thirdSmallLetter = char.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = 'A'; i <= bigLetter; i++)
            {
                for (char j = 'a'; j <= firstSmallLetter; j++)
                {
                    for (char k = 'a'; k <= secondSmallLetter; k++)
                    {
                        for (char l = 'a'; l <= thirdSmallLetter; l++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                counter++;
                                /*if (i==bigLetter && j==letter1 && k==letter2 && l==letter3 && m==num)
                                {
                                    break;
                                }
                                counter++;
                                */
                            }
                        }
                    }
                }
            }
            counter--;
            Console.WriteLine(counter);
        }
    }
}
