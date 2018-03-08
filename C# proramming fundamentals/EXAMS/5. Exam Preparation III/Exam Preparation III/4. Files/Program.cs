using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> storage = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string root = input[0];
                string fileName = input[input.Length - 2];
                long fileSize = long.Parse(input[input.Length - 1]);

                if (storage.ContainsKey(root))
                {
                    if (storage[root].ContainsKey(fileName) == false)
                    {
                        storage[root].Add(fileName, fileSize);
                    }
                    storage[root][fileName] = fileSize;
                }
                else
                {
                    storage.Add(root, new Dictionary<string, long> { { fileName, fileSize } });
                }
            }

            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string extension = command[0];
            string dir = command[2];

            var sorted = storage.Where(x => x.Key == dir).OrderByDescending(f => f.Value.Values);

            foreach (var r in sorted)
            {
                foreach (var item in r.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
                {
                    if (item.Key.Split('.').Last() == extension)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}