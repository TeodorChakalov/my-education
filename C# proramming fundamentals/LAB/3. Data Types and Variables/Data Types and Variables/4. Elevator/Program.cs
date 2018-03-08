using System;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacityOfTheElevator = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < people; i+=capacityOfTheElevator)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}