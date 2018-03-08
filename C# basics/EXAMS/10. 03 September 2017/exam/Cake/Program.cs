//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Cake
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var widthCake = int.Parse(Console.ReadLine());
//            var lengthCake = int.Parse(Console.ReadLine());
//            var totalPieces = widthCake * lengthCake;
//            var taken = 0;

//            for (int i = 0; i < totalPieces; i++)
//            {
//                var countPieces = Console.ReadLine();

//                if (countPieces == "STOP")
//                {
//                    Console.WriteLine("{0} pieces are left.", totalPieces - taken);
//                    break;
//                }
//                else
//                {
//                    taken += int.Parse(countPieces);
//                    if (taken > totalPieces)
//                    {
//                        Console.WriteLine("No more cake left! You need {0} pieces more.", taken - totalPieces);
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}

using System;
public class Program
{
    public static void Main()
    {
        var widthCake = int.Parse(Console.ReadLine());
        var lengthCake = int.Parse(Console.ReadLine());
        var totalPieces = widthCake * lengthCake;
        while (totalPieces >= 0)
        {
            var countPieces = Console.ReadLine();
            if (countPieces == "STOP")
            {
                break;
            }
            totalPieces -= int.Parse(countPieces);

        }
        if (totalPieces >= 0)
        {
            Console.WriteLine("{0} pieces are left.", totalPieces);
        }
        else
        {
            Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(totalPieces));
        }
    }
}