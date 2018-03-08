using System;

namespace _6.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string thiefID = Console.ReadLine();
            int countID = int.Parse(Console.ReadLine());

            long max = long.MinValue;

            for (int i = 0; i < countID; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());

                if(thiefID == "sbyte")
                {
                    if(currentNumber >= sbyte.MinValue && currentNumber <= sbyte.MaxValue)
                    {
                        if(currentNumber > max)
                        {
                            max = currentNumber;
                        }
                    }
                }
                else if(thiefID == "int")
                {
                    if (currentNumber >= int.MinValue && currentNumber <= int.MaxValue)
                    {
                        if (currentNumber > max)
                        {
                            max = currentNumber;
                        }
                    }
                }
                else if (thiefID == "long")
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
            Console.WriteLine(max);
        }
    }
}