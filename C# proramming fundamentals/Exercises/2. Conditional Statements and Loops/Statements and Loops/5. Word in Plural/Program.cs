using System;

namespace _5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 2,1);
                Console.WriteLine("{0}" + "ies", word);
            }
            else if(word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                Console.WriteLine("{0}" + "es", word);
            }
            else
            {
                Console.WriteLine("{0}" + 's', word);
            }
        }
    }
}