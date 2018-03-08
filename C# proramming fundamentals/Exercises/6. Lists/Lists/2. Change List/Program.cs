using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while(input != "Odd" && input != "Even")
            {
                string[] commandArgs = input.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "Delete":
                        int number = int.Parse(commandArgs[1]);
                        //list.RemoveAll(x => x == number);
                        while (list.Contains(number))
                        {
                            list.Remove(number);
                        }
                        //for (int i = 0; i < list.Count; i++)
                        //{
                        //    list.Remove(number);
                        //}
                        break;
                    case "Insert":
                        int num = int.Parse(commandArgs[1]);
                        int index = int.Parse(commandArgs[2]);

                        list.Insert(index, num);
                        break;
                }
                input = Console.ReadLine();
            }

            if(input == "Odd")
            {
                //Console.WriteLine(string.Join(" ", list.Where(x => x % 2 !=0)));
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
            }
            else if (input == "Even")
            {
                //Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0)));
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}