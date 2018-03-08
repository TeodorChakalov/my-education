using System;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var currentNumber = i;

                if (i < 10)
                {
                    if (i == 5 || i == 7 || i == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }
                else
                {
                    var firstNum = i / 10;
                    var secondNum = i % 10;
                    if (firstNum + secondNum == 5 || firstNum + secondNum == 7 || firstNum + secondNum == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }
            }
        }
    }
}