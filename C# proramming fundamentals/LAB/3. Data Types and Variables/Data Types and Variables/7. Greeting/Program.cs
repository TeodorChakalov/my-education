using System;

namespace _7.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
        }
    }
}