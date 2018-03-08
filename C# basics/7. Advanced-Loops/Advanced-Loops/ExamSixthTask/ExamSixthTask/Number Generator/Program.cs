using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int a = M; a >= 1; a--)
            {
                for (int b = N; b >= 1; b--)
                {
                    for (int c = L; c >= 1; c--)
                    {
                        //  int number = int.Parse($"{a}{b}{c}");
                        int number = a * 100 + b * 10 + c;
                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }

                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                            return;
                        }
                    }
                }
            }
            if(specialNumber < controlNumber)
            {
                Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
            }
        }
    }
}
