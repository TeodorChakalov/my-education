using System;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            try
            {
                var text = long.Parse(str);

                Console.WriteLine("{0} can fit in:", text);

                if (text >= sbyte.MinValue && text <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (text >= byte.MinValue && text <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (text >= short.MinValue && text <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (text >= ushort.MinValue && text <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (text >= int.MinValue && text <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (text >= uint.MinValue && text <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (text >= long.MinValue && text <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch
            {
                Console.WriteLine("{0} can't fit in any type", str);
            }
        }
    }
}