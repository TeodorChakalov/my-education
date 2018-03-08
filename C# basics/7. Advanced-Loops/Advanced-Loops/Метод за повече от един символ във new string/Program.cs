using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_за_повече_от_един_символ_във_new_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatString("text ", 26));
        }
        private static string RepeatString(string textToRepeat, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(textToRepeat);
            }

            return result.ToString();
        }
    }
}
