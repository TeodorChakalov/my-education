using System;
using System.Linq;

namespace _6.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int jewels = array[0];
            int gold = array[1];

            int totalExpenses = 0;
            int totalProfit = 0;

            string command = Console.ReadLine();

            while(command != "Jail Time")
            {
                string[] commandArgs = command.Split(' ');
                string loot = commandArgs[0];
                int heistExpenses = int.Parse(commandArgs[1]);

                totalExpenses += heistExpenses;

                for (int i = 0; i < loot.Length; i++)
                {
                    if(loot[i] == '%')
                    {
                        totalProfit += jewels;
                    }
                    else if (loot[i] == '$')
                    {
                        totalProfit += gold;
                    }
                }
                //foreach (var item in loot)
                //{
                //    if(item == '%')
                //    {
                //        totalProfit += jewels;
                //    }
                //    else if(item == '$')
                //    {
                //        totalProfit += gold;
                //    }
                //}

                command = Console.ReadLine();
            }

            if(totalProfit >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalProfit - totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses - totalProfit);
            }
        }
    }
}