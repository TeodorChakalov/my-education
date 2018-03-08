using System;
using System.Linq;

namespace _8.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //char[] lowerCaseAlphabet = new char[26];
            //int index = 0;

            //for (char letter = 'a'; letter <= 'z'; letter++)
            //{
            //    lowerCaseAlphabet[index] = letter;
            //    index++;
            //}

            //char[] upperCaseAlphabet = new char[26];
            //index = 0;

            //for (char letter = 'A'; letter <= 'Z'; letter++)
            //{
            //    upperCaseAlphabet[index] = letter;
            //    index++;
            //}

            //decimal result = 0;
            //decimal totalResult = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    decimal currentNumber = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
            //    char firstLetter = char.Parse(input[i].Substring(0, 1));
            //    char lastLetter = char.Parse(input[i].Substring(input[i].Length - 1, 1));

            //    if (char.IsUpper(firstLetter))
            //    {
            //        for (int position = 0; position < 26; position++)
            //        {
            //            if (upperCaseAlphabet[position] == firstLetter)
            //            {
            //                result = currentNumber / (position + 1);
            //                break;
            //            }
            //        }
            //    }
            //    else if (Char.IsLower(firstLetter))
            //    {
            //        for (int position = 0; position < 26; position++)
            //        {
            //            if (lowerCaseAlphabet[position] == firstLetter)
            //            {
            //                result = currentNumber * (position + 1);
            //                break;
            //            }
            //        }
            //    }

            //    if (Char.IsUpper(lastLetter))
            //    {
            //        for (int position = 0; position < 26; position++)
            //        {
            //            if (upperCaseAlphabet[position] == lastLetter)
            //            {
            //                totalResult += result - (position + 1);
            //                break;
            //            }
            //        }
            //    }
            //    else if (Char.IsLower(lastLetter))
            //    {
            //        for (int position = 0; position < 26; position++)
            //        {
            //            if (lowerCaseAlphabet[position] == lastLetter)
            //            {
            //                totalResult += result + (position + 1);
            //                break;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("{0:F2}", totalResult);

            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal sum = 0m;
            foreach (var word in input)
            {
                char before = word[0];
                char after = word[word.Length - 1];
                decimal number = decimal.Parse(string.Concat(word.Skip(1).Take(word.Length - 2)));

                if (char.IsUpper(before))
                {
                    number /= before - 64;
                }
                else
                {
                    number *= before - 96;
                }
                if (char.IsUpper(after))
                {
                    number -= after - 64;
                }
                else
                {
                    number += after - 96;
                }
                sum += number;
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}