using System;

namespace _1.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            var freebelt = countOfStudents;

            if(countOfStudents > 6)
            {
                for (int i = 6; i <= countOfStudents; i+=6)
                {
                    freebelt -= 1;
                }
            }
            var multiply = Math.Ceiling(countOfStudents + 0.1 * countOfStudents);
            var first = priceOfLightsabers * multiply;
            var second = priceOfRobes * countOfStudents;
            var third = priceOfBelts * freebelt;

            var result = first + second + third;

            if (result <= amountOfMoney)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", result);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.", result - amountOfMoney);
            }
        }
    }
}