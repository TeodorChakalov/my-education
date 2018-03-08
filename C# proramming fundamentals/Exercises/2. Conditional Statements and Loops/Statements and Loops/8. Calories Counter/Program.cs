using System;

namespace _8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var total = 0;


            for (int i = 0; i < number; i++)
            {
                var ingredients = Console.ReadLine().ToLower();

                if(ingredients == "cheese")
                {
                    total += 500;
                }
                else if(ingredients == "tomato sauce")
                {
                    total += 150;
                }
                else if(ingredients == "salami")
                {
                    total += 600;
                }
                else if(ingredients == "pepper")
                {
                    total += 50;
                }
            }
            Console.WriteLine("Total calories: {0}", total);
        }
    }
}