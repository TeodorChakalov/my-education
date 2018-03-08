using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().ToLower();
            var str2 = Console.ReadLine().ToLower();
            if(str1 == str2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}