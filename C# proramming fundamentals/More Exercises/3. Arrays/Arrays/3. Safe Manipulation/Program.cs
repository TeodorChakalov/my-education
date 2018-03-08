using System;
using System.Linq;

namespace _3.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] commandArgs = command.Split(' ');

                if(commandArgs[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                }
                else if(commandArgs[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if(commandArgs[0] == "Replace")
                {
                    try
                    {
                        int index = int.Parse(commandArgs[1]);
                        string text = commandArgs[2];
                        array[index] = text;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}