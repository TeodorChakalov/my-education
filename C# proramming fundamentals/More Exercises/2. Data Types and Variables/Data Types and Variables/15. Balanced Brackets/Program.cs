using System;

namespace _15.Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string lastBracket = "";
            string balance = "BALANCED";

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (lastBracket == "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    lastBracket = "(";
                }
                else if (input == ")")
                {
                    if (lastBracket != "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    lastBracket = ")";
                }
            }
            if(lastBracket == "(")
            {
                balance = "UNBALANCED";
            }
            Console.WriteLine(balance);
        }
    }
}