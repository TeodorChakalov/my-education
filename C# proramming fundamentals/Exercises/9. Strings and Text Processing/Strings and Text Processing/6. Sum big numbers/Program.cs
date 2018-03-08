using System;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        //BigInteger first = BigInteger.Parse(Console.ReadLine());
        //BigInteger second = BigInteger.Parse(Console.ReadLine());

        //Console.WriteLine("{0}", first + second);

        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        if (firstNumber.Length > secondNumber.Length)
        {
            secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
        }
        else if (firstNumber.Length < secondNumber.Length)
        {
            firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
        }

        int reminder = 0;
        int sum = 0;
        int num = 0;

        StringBuilder sb = new StringBuilder();

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            sum = firstNumber[i] - 48 + secondNumber[i] - 48 + reminder;
            num = sum % 10;
            if(sum > 9)
            {
                reminder = 1;
            }
            else
            {
                reminder = 0;
            }
            sb.Append(num);

            if(i == 0 && reminder == 1)
            {
                sb.Append(reminder);
            }
        }
        Console.WriteLine(sb.ToString().TrimEnd('0').Reverse().ToArray());
    }
}