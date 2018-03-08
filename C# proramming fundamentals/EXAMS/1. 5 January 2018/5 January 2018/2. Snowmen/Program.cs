using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while(numbers.Length > 1)
            {
                List<int> losers = new List<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int attacker = i;
                    int target = numbers[i];

                    //if (target > numbers.Length)
                    //{
                    //    target %= numbers.Length;
                    //}
                    target = target % numbers.Length;
                        
                    int difference = Math.Abs(attacker - target);

                    if (numbers.Length - losers.Count == 1)
                    {
                        break;
                    }

                    if (losers.Contains(i))
                    {
                        continue;
                    }

                    if (attacker == target)
                    {
                        Console.WriteLine("{0} performed harakiri", attacker);
                        losers.Add(attacker);
                        numbers[attacker] = -1;
                    }
                    else if(difference % 2 == 0)
                    {
                        Console.WriteLine("{0} x {1} -> {0} wins", attacker, target, attacker);
                        losers.Add(target);
                        numbers[target] = -1;
                    }
                    else if(difference % 2 != 0)
                    {
                        Console.WriteLine("{0} x {1} -> {1} wins", attacker, target, target);
                        losers.Add(attacker);
                        numbers[attacker] = -1;
                    }
                    losers = losers.Distinct().ToList();
                }

                numbers = numbers.Where(x => x != -1).ToArray();
            }
        }
    }
}