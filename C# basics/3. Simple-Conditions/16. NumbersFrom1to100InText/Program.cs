using System;

class NumbersToText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number <= 19)
        {
            Print0to19(number);
        }

        else if (number >= 20 && number <= 99)
        {
            Print20To99(number);
        }

            if (number == 100)
            {
                Console.WriteLine("сто");
            }

            if (number < 0 && number > 100)
            {
                Console.WriteLine("Въведи число между 0 и 100");
            }
    }


    private static void Print20To99(int number)
    {
        var decs = number / 10;
        var secs = number % 10;

        switch (decs)
        {
            case 2: Console.Write("двадесет"); break;
            case 3: Console.Write("тридесет"); break;
            case 4: Console.Write("четиредесет"); break;
            case 5: Console.Write("петдесет"); break;
            case 6: Console.Write("шестдесет"); break;
            case 7: Console.Write("седемдесет"); break;
            case 8: Console.Write("осемдесет"); break;
            case 9: Console.Write("деветдесет"); break;
        }

        switch (secs)
        {
            case 1: Console.WriteLine(" и едно"); break;
            case 2: Console.WriteLine(" и две"); break;
            case 3: Console.WriteLine(" и три"); break;
            case 4: Console.WriteLine(" и четири"); break;
            case 5: Console.WriteLine(" и пет"); break;
            case 6: Console.WriteLine(" и шест"); break;
            case 7: Console.WriteLine(" и седем"); break;
            case 8: Console.WriteLine(" и осем"); break;
            case 9: Console.WriteLine(" и девет"); break;
        }
    }

    private static void Print0to19(int number)
    {
        switch (number)
        {
            case 0: Console.WriteLine("нула"); break;
            case 1: Console.WriteLine("едно"); break;
            case 2: Console.WriteLine("две"); break;
            case 3: Console.WriteLine("три"); break;
            case 4: Console.WriteLine("четири"); break;
            case 5: Console.WriteLine("пет"); break;
            case 6: Console.WriteLine("шест"); break;
            case 7: Console.WriteLine("седем"); break;
            case 8: Console.WriteLine("осем"); break;
            case 9: Console.WriteLine("девет"); break;
            case 10: Console.WriteLine("десет"); break;
            case 11: Console.WriteLine("единадесет"); break;
            case 12: Console.WriteLine("дванадесет"); break;
            case 13: Console.WriteLine("тринадесет"); break;
            case 14: Console.WriteLine("четиринадесет"); break;
            case 15: Console.WriteLine("петнадесет"); break;
            case 16: Console.WriteLine("шестнадесет"); break;
            case 17: Console.WriteLine("седемнадесет"); break;
            case 18: Console.WriteLine("осемнадесет"); break;
            case 19: Console.WriteLine("деветнадесет"); break;
        }
    }
}

//int number = int.Parse(Console.ReadLine());

//        if (number >= 0 && number <= 19)
//        {
//            switch (number)
//            {
//                case 0: Console.WriteLine("zero"); break;
//                case 1: Console.WriteLine("one"); break;
//                case 2: Console.WriteLine("two"); break;
//                case 3: Console.WriteLine("three"); break;
//                case 4: Console.WriteLine("four"); break;
//                case 5: Console.WriteLine("five"); break;
//                case 6: Console.WriteLine("six"); break;
//                case 7: Console.WriteLine("seven"); break;
//                case 8: Console.WriteLine("eight"); break;
//                case 9: Console.WriteLine("nine"); break;
//                case 10: Console.WriteLine("ten"); break;
//                case 11: Console.WriteLine("eleven"); break;
//                case 12: Console.WriteLine("twelve"); break;
//                case 13: Console.WriteLine("thirteen"); break;
//                case 14: Console.WriteLine("fourteen"); break;
//                case 15: Console.WriteLine("fifteen"); break;
//                case 16: Console.WriteLine("sixteen"); break;
//                case 17: Console.WriteLine("seventeen"); break;
//                case 18: Console.WriteLine("eighteen"); break;
//                case 19: Console.WriteLine("nineteen"); break;
//            }
//        }
//        else if (number >= 20 && number <= 99)
//        {
//            int tens = number / 10;
//            int ones = number % 10;

//            switch (tens)
//            {
//                case 2: Console.Write("twenty"); break;
//                case 3: Console.Write("thirty"); break;
//                case 4: Console.Write("forty"); break;
//                case 5: Console.Write("fifty"); break;
//                case 6: Console.Write("sixty"); break;
//                case 7: Console.Write("seventy"); break;
//                case 8: Console.Write("eighty"); break;
//                case 9: Console.Write("ninety"); break;
//            }

//            switch (ones)
//            {
//                case 1: Console.WriteLine(" one"); break;
//                case 2: Console.WriteLine(" two"); break;
//                case 3: Console.WriteLine(" three"); break;
//                case 4: Console.WriteLine(" four"); break;
//                case 5: Console.WriteLine(" five"); break;
//                case 6: Console.WriteLine(" six"); break;
//                case 7: Console.WriteLine(" seven"); break;
//                case 8: Console.WriteLine(" eight"); break;
//                case 9: Console.WriteLine(" nine"); break;
//            }
//        }
//        else if (number == 100)
//        {
//            Console.WriteLine("one hundred");
//        }
//        else
//        {
//            Console.WriteLine("invalid number");
//        }