using System;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            var sum = "";

            for (int i = 1; i <= number; i++)
            {
                var text = Console.ReadLine();

                if (oddOrEven == "odd" && i % 2 != 0)
                {
                    sum += text + delimiter;
                }
                else if(oddOrEven == "even" && i % 2 == 0)
                {
                    sum += text + delimiter;
                }
            }
            Console.WriteLine("{0}", sum.Remove(sum.Length - 1));
        }
    }
}