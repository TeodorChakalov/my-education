using System;
using System.Linq;

namespace _2.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Reverse")
                {
                    array =  array.Reverse().ToArray();
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if(command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string text = command[2];
                    array[index] = text;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}