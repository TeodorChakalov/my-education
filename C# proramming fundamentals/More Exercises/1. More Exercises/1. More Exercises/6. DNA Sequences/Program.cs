using System;

namespace _6.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        string text = i + j + k >= number ? "O" : "X";
                        {
                            Console.Write($"{text}{i}{j}{k}{text} ".Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T"));
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}