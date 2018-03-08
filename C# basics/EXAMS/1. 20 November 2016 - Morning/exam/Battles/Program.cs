using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPokemonFirstPlayer = int.Parse(Console.ReadLine());
            var countPokemonSecondPlayer = int.Parse(Console.ReadLine());
            var maxCountBattles = int.Parse(Console.ReadLine());

            int counter = 0;
            for(int i = 1;i<=countPokemonFirstPlayer; i++)
            {
                for (int j = 1; j <= countPokemonSecondPlayer; j++)
                {
                    counter++;
                    if (counter <= maxCountBattles)
                    {
                        Console.Write("({0} <-> {1}) ", i,j);
                    }

                }
            }
        }
    }
}
