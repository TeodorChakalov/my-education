using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var sum = 0.0;
            for (int i = 0; i < str.Length; i++)
            {
                char symbol = str[i];

                switch (symbol)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
                //if (str[i] == 'a') sum += 1;
                //if (str[i] == 'e') sum += 2;
                //if (str[i] == 'i') sum += 3;
                //if (str[i] == 'o') sum += 4;
                //if (str[i] == 'u') sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
