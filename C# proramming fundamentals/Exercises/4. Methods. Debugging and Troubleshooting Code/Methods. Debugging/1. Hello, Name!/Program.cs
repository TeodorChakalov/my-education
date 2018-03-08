using System;

namespace _1.Hello__Name_
{
    class Program
    {
        static string GetName(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = GetName(name);
            Console.WriteLine("Hello, {0}!", result);
        }
    }
}