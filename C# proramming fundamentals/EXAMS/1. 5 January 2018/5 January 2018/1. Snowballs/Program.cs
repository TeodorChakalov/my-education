using System;
using System.Numerics;

namespace _1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger minValue = BigInteger.MinusOne;
            int snow = 0;
            int time = 0;
            BigInteger value = 0;
            int quantity = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuantity = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuantity);

                if(snowballValue > minValue)
                {
                    minValue = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    value = snowballValue;
                    quantity = snowballQuantity;
                }
            }
            Console.WriteLine("{0} : {1} = {2} ({3})", snow, time, value, quantity);

        }
    }
}