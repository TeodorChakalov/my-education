using System;

namespace _7.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            long max = long.MinValue;

            for (int i = 0; i < count; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());

                if (type == "sbyte")
                {
                    if (currentNumber >= sbyte.MinValue && currentNumber <= sbyte.MaxValue)
                    {
                        if (currentNumber > max)
                        {
                            max = currentNumber;
                        }
                    }
                }
                if (type == "int")
                {
                    if (currentNumber >= int.MinValue && currentNumber <= int.MaxValue)
                    {
                        if (currentNumber > max)
                        {
                            max = currentNumber;
                        }
                    }
                }
                if (type == "long")
                {
                    if (currentNumber >= long.MinValue && currentNumber <= long.MaxValue)
                    {
                        if (currentNumber > max)
                        {
                            max = currentNumber;
                        }
                    }
                }
            }

            var years = Math.Ceiling(max / 127d);
            if (max > 0)
            {
                if (years > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, years);
                }
                else
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", max, years);
                }
            }
            else
            {
                years = Math.Ceiling(max / -128d);
                if (years > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, years);
                }
                else
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", max, years);
                }
            }
        }
    }
}